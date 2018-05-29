using System;
using MySql.Data.MySqlClient;
namespace Tools.Db
{
    public class DB
    {
        private static DB instance;
        private MySqlConnection connection;
        private const string databaseName = "Data Source='localhost';" +
                                            "Database='airport';" +
                                            "UID='root';" +
                                            "PWD='root';";
        private DB()
        {
           connection = new MySqlConnection();
           connection.ConnectionString = databaseName;
        }

        public static DB GetInstanceDb()
        {
            if (instance == null)
            {
                instance = new DB();
                
            }
           
            return instance;
        }

        public MySqlConnection Connection()
        {
            return connection;
        }

        private Object Clone()
        {
            return false;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
        {
            optionbuilder.UseSqlite(@"Data Source=d:\Sample.db");
        }
    }
}