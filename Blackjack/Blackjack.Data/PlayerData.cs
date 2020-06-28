namespace Blackjack.Data
{
    public class ProfileInfo
    {

        //SUBJECT TO CHANGE

        private const string encrypt_pass = "Merry_Christmas";
        public int ID { get; set; }
        private string _user { get; set; }
        private byte[] _password { get; set; }
        private string _name { get; set; }
        private string _phone { get; set; }
        private string _address { get; set; }
        private string _cardNumber { get; set; }

        public ProfileInfo( ) { }

        public ProfileInfo( string Username, string Name, string PhoneNumber, string Address, string CardNumber )
        {
            _user = Username;
            _name = Name;
            _phone = PhoneNumber;
            _address = Address;
            _cardNumber = CardNumber;
        }

        public ProfileInfo( string Username, string password, string Name, string PhoneNumber, string Address, string CardNumber )
        {
            _user = Username;
            _name = Name;
            _phone = PhoneNumber;
            _address = Address;
            _cardNumber = CardNumber;
        }

        public void SetUser( string User ) { _user = User; }

        public void SetName( string Name ) { _name = Name; }

        public void SetPhone( string Phone ) { _phone = Phone; }

        public void SetAddress( string Address ) { _address = Address; }

        public void SetCardNumber( string CardNumber ) { _cardNumber = CardNumber; }

        public string User => _user;

        public byte[] StorePassword => _password;

        public string Name => _name;
        public string PhoneNumber => _phone;
        public string Address => _address;
        public string GetCardNumber( ) => _cardNumber;

        public void ServerSetPassword( byte[] flow ) { _password = flow; }
    }
}
