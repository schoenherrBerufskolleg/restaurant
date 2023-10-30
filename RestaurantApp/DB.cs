//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data.SQLite;

//namespace RestaurantApp
//{
     //class DatabaseManager
    //{
        ////readonly string databasePath = "Data Source=C:\\Users\\MBösert\\Desktop\\projekt\\restaurant-main\\Sql\\Restaurant";
        ////readonly string databasePath = "Data Source=H:\\repo\\restaurant\\fromGit\\Sql\\Restaurant";
        //readonly string databasePath = "Data Source=C:\\Users\\Megaport\\Documents\\Schule\\Projekt\\restaurant\\Sql\\Restaurant";
        //SQLiteConnection conn;

        //public void Connect()
        //{
            //conn = new SQLiteConnection(databasePath);
            //conn.Open();
        //}

        //public void Disconnect()
        //{
            //conn.Close();
        //}

        //public void ExecuteCommand(string command)
        //{
            //SQLiteCommand cmd = conn.CreateCommand();
            //cmd.CommandText = command;
            //Console.WriteLine("Amount of columns affected: " + cmd.ExecuteNonQuery());
        //}

        //public SQLiteDataReader ExecuteQuery(string query)
        //{
            //SQLiteCommand cmd = conn.CreateCommand();
            //cmd.CommandText = query;
            //SQLiteDataReader reader = cmd.ExecuteReader();   
            //return reader;
            ////while(reader.Read())
            ////{
                ////int id = reader.GetInt32(0);
                ////string name = reader.GetString(1); 

                ////Console.WriteLine($"ID: {id}, Name: {name}");
            ////}
        //}
    //}
//}
