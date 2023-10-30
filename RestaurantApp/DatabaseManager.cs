using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace RestaurantApp
{
     class DatabaseManager
    {
        //readonly string databasePath = "Data Source=C:\\Users\\MBösert\\Desktop\\projekt\\restaurant-main\\Sql\\Restaurant";
        //readonly string databasePath = "Data Source=H:\\repo\\restaurant\\fromGit\\Sql\\Restaurant";
        readonly string databasePath = "Data Source=C:\\Users\\Megaport\\Documents\\Schule\\Projekt\\restaurant\\Sql\\Restaurant";
        SQLiteConnection conn;
        /**
         * Connects to the database of the given databasePath
         */
        public void Connect()
        {
            conn = new SQLiteConnection(databasePath);
            conn.Open();
        }
        /**
         * Disconnects from the database
         */
        public void Disconnect()
        {
            conn.Close();
        }
        /**
         * Executes a given command on the connected database and returns the amount of lines affected
         */
        public int ExecuteCommand(string command)
        {
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = command;
            return cmd.ExecuteNonQuery();
        }
        /**
         * Executes a given query on the connected database and returns
         * the Reader Object so the caller can easily handle the response data
         */
        public SQLiteDataReader ExecuteQuery(string query)
        {
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;
            SQLiteDataReader reader = cmd.ExecuteReader();   
            return reader;
        }
    }
}
