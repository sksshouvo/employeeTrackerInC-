using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace employee_tracker
{
    class sqllite_class
    {
        public static void sqlconnection() {
            string cs = "Data Source=:memory:";
            string stm = "SELECT SQLITE_VERSION()";
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(stm, con);
            string version = cmd.ExecuteScalar().ToString();

            Console.WriteLine($"SQLite version: {version}");
        }
        
    }
}
