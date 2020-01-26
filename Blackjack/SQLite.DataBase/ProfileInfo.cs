using System.Security.Cryptography;
using System.Text;

namespace Storage
{
    public class ProfileInfo
    {
        private const string encrypt_pass = "Merry_Christmas";
        public int ID { get; set; }
        private string _user { get; set; }
        private byte[] _password { get; set; }
        private string _name { get; set; }
        private string _phone { get; set; }
        private string _address { get; set; }
        private string _cardNumber { get; set; }

        public ProfileInfo() { }

        public ProfileInfo(string Username, string Name, string PhoneNumber, string Address, string CardNumber)
        {
            _user = Username;
            _name = Name;
            _phone = PhoneNumber;
            _address = Address;
            _cardNumber = CardNumber;
        }

        public ProfileInfo(string Username, string password, string Name, string PhoneNumber, string Address, string CardNumber)
        {
            _user = Username;
            _name = Name;
            _phone = PhoneNumber;
            _address = Address;
            _cardNumber = CardNumber;
            SetPassword(password);
        }

        public void SetUser(string User) { _user = User; }

        public void SetPassword(string Password)
        {
            #region First attempt at encryption
            /*
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
                byte[] utfD1 = new UTF8Encoding(false).GetBytes(Password);

                encrypt.Write(utfD1, 0, utfD1.Length);
                encrypt.FlushFinalBlock();
                encrypt.Close();
                _password = encryptionStream.ToArray();
                k1.Reset();
            }
            catch (Exception)
            {
                Debug.WriteLine("failure to encrypt");
                //make sure there is a marker that says that something broke with the password because then it will try and decrypt it
            }

                    ---first attempt at encryption---
            */

            #endregion

            _password = ProtectedData.Protect(Encoding.Unicode.GetBytes(Password), null, DataProtectionScope.CurrentUser);

        }

        public void SetName(string Name) { _name = Name; }

        public void SetPhone(string Phone) { _phone = Phone; }

        public void SetAddress(string Address) { _address = Address; }

        public void SetCardNumber(string CardNumber) { _cardNumber = CardNumber; }

        public string GetPassword()
        {

            #region first attempt at decryption
            /*
            byte[] salt1 = new byte[8];

            using (RNGCryptoServiceProvider rNGCrypto = new RNGCryptoServiceProvider())
            {
                rNGCrypto.GetBytes(salt1);
            }

            Rfc2898DeriveBytes k1 = new Rfc2898DeriveBytes(encrypt_pass, salt1);
            Rfc2898DeriveBytes k2 = new Rfc2898DeriveBytes(encrypt_pass, salt1);

            // Encrypt the data.
            TripleDES encAlg = TripleDES.Create();
            encAlg.Key = k1.GetBytes(16);
            MemoryStream encryptionStream = new MemoryStream();
            CryptoStream encrypt = new CryptoStream(encryptionStream, encAlg.CreateEncryptor(), CryptoStreamMode.Write);
            byte[] utfD1 = new UTF8Encoding(false).GetBytes("test");

            encrypt.Write(utfD1, 0, utfD1.Length);
            encrypt.FlushFinalBlock();
            encrypt.Close();
            byte[] edata1 = encryptionStream.ToArray();
            k1.Reset();

            // Try to decrypt, thus showing it can be round-tripped.
            TripleDES decAlg = TripleDES.Create();
            decAlg.Key = k2.GetBytes(16);
            decAlg.IV = encAlg.IV;
            MemoryStream decryptionStreamBacking = new MemoryStream();
            CryptoStream decrypt = new CryptoStream(decryptionStreamBacking, decAlg.CreateDecryptor(), CryptoStreamMode.Write);
            decrypt.Write(_password, 0, _password.Length);
            decrypt.Flush();
            decrypt.Close();
            k2.Reset();
            string decrypt_pass = new UTF8Encoding(false).GetString(decryptionStreamBacking.ToArray());

            return decrypt_pass;
            */
            #endregion

            return Encoding.Unicode.GetString(
                ProtectedData.Unprotect(_password, null, DataProtectionScope.CurrentUser)
            );
        }

        public string GetUser() { return _user; }
        public byte[] StorePassword() { return _password; }
        public string GetName() { return _name; }
        public string GetPhoneNumber() { return _phone; }
        public string GetAddress() { return _address; }
        public string GetCardNumber() { return _cardNumber; }

        public void ServerSetPassword(byte[] flow) { _password = flow; }
    }
}