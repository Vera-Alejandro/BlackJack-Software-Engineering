using System;
using System.Security.Cryptography;
using System.IO;
using System.Diagnostics;
using System.Text;

namespace Storage
{
    public class ProfileInfo
    {
        private const string encrypt_pass = "Merry_Christmas";
        private string _user { get; set; }
        private byte[] _password { get; set; }
        private string _name { get; set; }
        private string _phone { get; set; }
        private string _address { get; set; }
        private string _cardNumber { get; set; }


        public ProfileInfo()
        {

        }

        public void SetUser(string User) { _user = User; }

        public void SetPassword(string Password)
        {
            byte[] _password;
            string data1 = "who_lives_in_a_pinapple_under_the_sea";
            byte[] salt1 = new byte[8];

            using (RNGCryptoServiceProvider rNGCrypto = new RNGCryptoServiceProvider())
            {
                rNGCrypto.GetBytes(salt1);
            }

            try
            {
                Rfc2898DeriveBytes k1 = new Rfc2898DeriveBytes(encrypt_pass, salt1);
                Rfc2898DeriveBytes k2 = new Rfc2898DeriveBytes(encrypt_pass, salt1);

                // Encrypt the data.
                TripleDES encAlg = TripleDES.Create();
                encAlg.Key = k1.GetBytes(16);
                MemoryStream encryptionStream = new MemoryStream();
                CryptoStream encrypt = new CryptoStream(encryptionStream, encAlg.CreateEncryptor(), CryptoStreamMode.Write);
                byte[] utfD1 = new System.Text.UTF8Encoding(false).GetBytes(data1);

                encrypt.Write(utfD1, 0, utfD1.Length);
                encrypt.FlushFinalBlock();
                encrypt.Close();
                byte[] edata1 = encryptionStream.ToArray();
                k1.Reset();

            }
            catch (Exception)
            {
                Debug.WriteLine("failure to encrypt");
                //make sure there is a marker that says that something broke with the password because then it will try and decrypt it
            }
        }

        public void SetName(string Name) { _name = Name; }

        public void SetPhone(string Phone) { _phone = Phone; }

        public void SetAddress(string Address) { _address = Address; }

        public void SetCardNumber(string CardNumber) { _cardNumber = CardNumber; }

        public string GetPassword()
        {
            byte[] salt1 = new byte[8];
            byte[] edata = { 0, 1 };

            using (RNGCryptoServiceProvider rNGCrypto = new RNGCryptoServiceProvider())
            {
                rNGCrypto.GetBytes(salt1);
            }
        
            Rfc2898DeriveBytes k1 = new Rfc2898DeriveBytes(encrypt_pass, salt1);
            Rfc2898DeriveBytes k2 = new Rfc2898DeriveBytes(encrypt_pass, salt1);
            TripleDES encAlg = TripleDES.Create();

            // Try to decrypt, thus showing it can be round-tripped.
            TripleDES decAlg = TripleDES.Create();
            decAlg.Key = k2.GetBytes(16);
            decAlg.IV = encAlg.IV;
            MemoryStream decryptionStreamBacking = new MemoryStream();
            CryptoStream decrypt = new CryptoStream(decryptionStreamBacking, decAlg.CreateDecryptor(), CryptoStreamMode.Write);
            decrypt.Write(edata, 0, edata.Length);
            decrypt.Flush();
            decrypt.Close();
            k2.Reset();
            string decrypt_pass = new UTF8Encoding(false).GetString(decryptionStreamBacking.ToArray());

            return decrypt_pass;
        }

    }
}
