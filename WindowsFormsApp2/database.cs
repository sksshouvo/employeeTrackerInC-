using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace employee_tracker
{
    class database
    {
        public SQLiteConnection myConnection;
        
        //public void openConnection()
        //{
        //    if(myConnection.State != System.Data.ConnectionState.Open){
        //        myConnection.Open();
        //    }
        //}

        //public void closeConnection() {
        //    if (myConnection.State != System.Data.ConnectionState.Closed)
        //    {
        //        myConnection.Close();
        //    }
        //}
        public database()
        {

            if (!File.Exists("./database.sqlite3"))
            {
                SQLiteConnection.CreateFile("database.sqlite3");
                Console.WriteLine("Database created");
                string cs = @"URI=file:database.sqlite3";
                var con = new SQLiteConnection(cs);
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand(con);
                cmd.CommandText = "DROP TABLE IF EXISTS cars";
                cmd.ExecuteNonQuery();
                cmd.CommandText = @"CREATE TABLE remember_users (id INTEGER NOT NULL PRIMARY KEY, email TEXT NOT NULL, _tokens TEXT NOT NULL, remember_me TEXT NOT NULL,created_at TEXT DEFAULT CURRENT_TIMESTAMP)";
                cmd.ExecuteNonQuery();
            }
            else {

            }
            


        }


    }
}
