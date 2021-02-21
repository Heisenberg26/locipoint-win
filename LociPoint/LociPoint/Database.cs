using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LociPoint
{
    public class Database
    {
        public SQLiteConnection myConnection;
        public static SQLiteConnection returnConnection()
        {
            SQLiteConnection myConnection = new SQLiteConnection(LoadConnectionString());
            return myConnection;

        }
        private static string LoadConnectionString(string id = "connString")
        {

            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static List<T> selectionQuery<T>(string query, DynamicParameters param)
        {
            using (IDbConnection cnn = Database.returnConnection())
            {

                var output = cnn.Query<T>(query, param);
                return output.ToList();
            }
        }
        
        public static void executeQuery(string query, DynamicParameters param) {
            using (IDbConnection cnn = Database.returnConnection())
            {
                cnn.Execute(query, param);
            }


        }
    }
}
