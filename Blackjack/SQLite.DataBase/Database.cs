using SQLite.Storage;
using System;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;

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
        public void SaveGameState(GameData gameData, string profile)
        {

        }
    }
}
