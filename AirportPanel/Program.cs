using System;
using Tools.Db;

namespace AirportPanel
{
    internal class Program
    {
        
        public static void Main(string[] args)
        {
            var db = DB.GetInstanceDb().Connection();
            db.Clone();
            using (db)
            {
                db.Open();
                var command = db.CreateCommand();
                command.CommandText = "Create table plane(" +
                                      "id int unsigned NOT NULL AUTO_INCREMENT," +
                                      "Primary key (id))";
                command.ExecuteNonQuery();
                Console.WriteLine(db.Database);
                Console.WriteLine(db.State);
            }
            Console.WriteLine(db.State);
            System.Console.ReadLine();
        }
    }
}