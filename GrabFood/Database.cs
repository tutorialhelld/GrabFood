using System;
using System.IO;
using System.Windows.Forms;
using System.Data.SQLite;

namespace GrabFood
{
    public class Database
    {
        public static SQLiteConnection GetConnection()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string dbPath = Path.Combine(baseDir, "GrabDB.db");

            // SANITY CHECK: Let's see if the code actually finds the file
            if (!File.Exists(dbPath))
            {
                MessageBox.Show($"Code cannot find the file at:\n{dbPath}\n\n" +
                                $"Please check if the file name has a double extension like GrabDB.db.db",
                                "Database Missing");
            }

            // Standard connection string format for System.Data.SQLite on .NET 8
            SQLiteConnection conn = new SQLiteConnection($"Data Source={dbPath};");
            conn.Open();

            return conn;
        }
    }
}