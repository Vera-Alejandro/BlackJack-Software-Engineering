using System;
using System.Security.Cryptography;
using System.IO;
using System.Diagnostics;
using System.Text;

namespace Storage
{
    public class ProfileInfo
    {
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
            string pinapple = "who_lives_in_a_pinapple_under_the_sea";
            byte[] salt1 = new byte[8];

            using (RNGCryptoServiceProvider rNGCrypto = new RNGCryptoServiceProvider())
            {
                rNGCrypto.GetBytes(salt1);
            }

            try
            {
                Rfc2898DeriveBytes key1 = new Rfc2898DeriveBytes(pinapple, salt1);
                Rfc2898DeriveBytes key2 = new Rfc2898DeriveBytes(pinapple, salt1);

                TripleDES tripleDES = TripleDES.Create();
                tripleDES.Key = key1.GetBytes(16);
                MemoryStream encryptionStream = new MemoryStream();
                CryptoStream encrypt = new CryptoStream(encryptionStream, tripleDES.CreateDecryptor(), CryptoStreamMode.Write);
                byte[] encryptedPass = new System.Text.UTF8Encoding(false).GetBytes(Password);

                encrypt.Write(encryptedPass, 0, encryptedPass.Length);
                encrypt.FlushFinalBlock();
                encrypt.Close();

                _password = encryptionStream.ToArray();

                key1.Reset();
            }
            catch (Exception)
            {
                Debug.WriteLine("failure to encrypt");
                _password = Encoding.ASCII.GetBytes(Password);
                //make sure there is a marker that says that something broke with the password because then it will try and decrypt it
            }
        }

        public void SetName(string Name) { _name = Name; }

        public void SetPhone(string Phone) { _phone = Phone; }

        public void SetAddress(string Address) { _address = Address; }

        public void SetCardNumber(string CardNumber) { _cardNumber = CardNumber; }



    }
}
