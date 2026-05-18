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

            if (!File.Exists(dbPath))
            {
                MessageBox.Show("Database not found:\n" + dbPath);
            }

            SQLiteConnection conn = new SQLiteConnection(
                $"Data Source={dbPath};Version=3;Pooling=False;"
            );

            conn.Open();
            return conn;
        }
    }
}