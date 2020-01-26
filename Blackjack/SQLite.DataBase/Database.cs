using SQLite.Storage;
using Storage;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using Dapper;
using System.Linq;

namespace SQLite
{
    public class Database
    {
        private SQLiteConnection _fileConnection { get; set; }
        private string constr { get; set; }
        private readonly string _sqlitePath;

        /// <summary>
        /// Creates a connection to the SQLite file that is passed in as a parameter.
        /// </summary>
        /// <param name="FilePath"></param>
        public Database(string FilePath)
        {
           _sqlitePath = FilePath;
            constr = $"Data Source={_sqlitePath};Version=3;";

            if (!File.Exists(_sqlitePath))
            {
                SQLiteConnection.CreateFile(_sqlitePath);
                Debug.WriteLine("SQLite File Created.");
            }

            _fileConnection = new SQLiteConnection(constr);
        }

        /// <summary>
        /// Creates connection to the SQlite db file.
        /// </summary>
        /// <returns>
        /// Returns if connection was successfully made.
        /// </returns>
        public bool Connect()
        {
            if (File.Exists(_sqlitePath) && _fileConnection.State != ConnectionState.Open)
            {
                _fileConnection.Open();
                Debug.WriteLine("~File connection made.");
                return true;
            }
            else
            {
                if (!File.Exists(_sqlitePath))
                {
                    Debug.WriteLine("~File connection was not made. File not found.");
                    return false;
                }

                if (_fileConnection.State == ConnectionState.Open)
                {
                    Debug.WriteLine("~File connection was not made. File connection is already open");
                    return false;
                }

                Debug.WriteLine("~File connection was not made due to unknown error");
                return false;
            }
        }

        /// <summary>
        /// Safely closes connection to SQLite db file.
        /// </summary>
        /// <returns>
        /// Returns if connection closure was successful.
        /// </returns>
        public bool Disconnect()
        {
            if (File.Exists(_sqlitePath) && _fileConnection.State != ConnectionState.Closed)
            {
                _fileConnection.Close();
                Debug.WriteLine("~Sqlite db connection closed successfully.");
                return true;
            }
            else
            {
                if (!File.Exists(_sqlitePath))
                {
                    Debug.WriteLine("~Did not close file. File not found.");
                    return false;
                }

                if (_fileConnection.State == ConnectionState.Closed)
                {
                    Debug.WriteLine("~Could not close file. File connection is already closed");
                    return false;
                }

                Debug.WriteLine("~File closure was not made due to unknown error");
                return false;
            }
        }

        /// <summary>
        /// Saves the game state data as entry in te profile table in SQLite
        /// </summary>
        /// <param name="gameData"></param>
        public void SaveGameState(GameData gameData, string UserName)
        {
            string create_table = $"CREATE TABLE IF NOT EXISTS {UserName} (" +
                $"MoneyBet INT," +
                $"MoneyWon INT," +
                $"MoneyLost INT," +
                $"MoneyLeftOver INT," +
                $"MostMoneyMade INT," +
                $"MostMoneyLost INT);";

            SQLiteCommand create = new SQLiteCommand(create_table, _fileConnection);
            create.ExecuteNonQuery();

            string _command = $"INSERT INTO {UserName} " +
                $"(MoneyBet, MoneyWon, MoneyLost, MoneyLeftOver, MostMoneyMade, MostMoneyLost) " +
                $"VALUES " +
                $"(@MoneyBet, @MoneyWon, @MoneyLost, @MoneyLeftOver, @MostMoneyMade, @MostMoneyLost);";

            SQLiteCommand _insertCmd = new SQLiteCommand(_command, _fileConnection);

            SQLiteParameter[] parameters =
            {
                new SQLiteParameter(@"MoneyBet", gameData.MoneyBet),
                new SQLiteParameter(@"MoneyWon", gameData.GetMoneyWon()),
                new SQLiteParameter(@"MoneyLost", gameData.GetMoneyLost()),
                new SQLiteParameter(@"MoneyLeftOver", gameData.GetMoneyLeftOver()),
                new SQLiteParameter(@"MostMoneyMade", gameData.MostMoneyMade),
                new SQLiteParameter(@"MostMoneyLost", gameData.MostMoneyLost),
            };
            _insertCmd.Parameters.AddRange(parameters);

            int rows_affected = _insertCmd.ExecuteNonQuery();

            Debug.WriteLine("rows affected :" + rows_affected);

        }

        /// <summary>
        /// Saves Profile to SQLite db file 
        /// </summary>
        /// <param name="profile"></param>
        /// <returns>
        /// returns the rows affected or -69 if user already exists in database
        /// </returns>
        public int SaveProfile(ProfileInfo profile)
        {
            string create_table = $"CREATE TABLE IF NOT EXISTS MasterProfile(" +
                $"ID INTEGER PRIMARY KEY," +
                $"Username TEXT," +
                $"Password BLOB," +
                $"FullName TEXT," +
                $"PhoneNumber TEXT," +
                $"Address TEXT," +
                $"CardNumber TEXT);";

            SQLiteCommand create = new SQLiteCommand(create_table, _fileConnection);
            create.ExecuteNonQuery();

            if (!DoesUserExist(profile.GetUser()))
            {
                string _command = $"INSERT INTO MasterProfile " +
                    $"(UserName, Password, FullName, PhoneNumber, Address, CardNumber) " +
                    $"VALUES " +
                    $"(@UserName, @Password, @FullName, @PhoneNumber, @Address, @CardNumber);";

                SQLiteCommand _insertCmd = new SQLiteCommand(_command, _fileConnection);

                SQLiteParameter[] parameters =
                {
                new SQLiteParameter(@"UserName", profile.GetUser()),
                new SQLiteParameter(@"Password", profile.StorePassword()),
                new SQLiteParameter(@"FullName", profile.GetName()),
                new SQLiteParameter(@"PhoneNumber", profile.GetPhoneNumber()),
                new SQLiteParameter(@"Address", profile.GetAddress()),
                new SQLiteParameter(@"CardNumber", profile.GetCardNumber()),
                };
                _insertCmd.Parameters.AddRange(parameters);

                int rows_affected = _insertCmd.ExecuteNonQuery();

                Debug.WriteLine("rows affected :" + rows_affected);

                return rows_affected;
            }
            else
            {
                return -69;
            }

        }

        /// <summary>
        /// this returns the profile data of the User inputed
        /// </summary>
        /// <param name="UserName">
        /// Username of the ProfileInfo that you want
        /// </param>
        /// <returns>
        /// Profile Info class with all data that is stored on that user
        /// Returns null if no data on user found
        /// </returns>
        public ProfileInfo GetProfileData(string Username)
        {
            var userCollection = _fileConnection.Query<SafeProfileInfo>(
                "SELECT * FROM MasterProfile WHERE Username = @Username", new { Username });

            SafeProfileInfo temp = userCollection.FirstOrDefault();

            ProfileInfo profileData = new ProfileInfo(temp.UserName, temp.FullName, temp.PhoneNumber, temp.Address, temp.CardNumber);
            profileData.ServerSetPassword(temp.Password);
            profileData.ID = temp.ID;

            return profileData;
        }

        public bool DoesUserExist(string UserName)
        {
            if (_fileConnection.State != ConnectionState.Open) { _fileConnection.Open(); }

            int count = _fileConnection.ExecuteScalar<int>(string.Format(
                        "SELECT COUNT(1) as 'Count' FROM MasterProfile WHERE Username = '{0}'",
                        UserName));

            return (count >= 1) ? true: false;
        }
    }

    /// <summary>
    /// !!!not to be used!!!
    /// </summary>
    internal class SafeProfileInfo
    {
        public int ID { get; set; }
        public string UserName {get; set;}
        public byte[] Password {get; set;}
        public string FullName {get; set;}
        public string PhoneNumber{get; set;}
        public string Address {get; set;}
        public string CardNumber {get; set;}
    }
}
