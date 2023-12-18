using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Reflection;

namespace RestaurantApp
{
     class DatabaseManager
    {
        string databasePath;

        SQLiteConnection conn;
        /**
         * Connects to the database of the given databasePath
         */
        public void Connect()
        {
            string assemblyPath = Assembly.GetExecutingAssembly().Location;
            string dir = Path.GetDirectoryName(assemblyPath);

            for (int i = 0; i < 4; i++)
            {
                dir = Directory.GetParent(dir).FullName;
            }
            Console.WriteLine("databasepath: " + dir);

            databasePath = $"Data Source={Path.Combine(Path.Combine(dir, "Sql"), "Restaurant")}";

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
