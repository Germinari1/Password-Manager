using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager_SDEV265
{
    /* =-=-=-==-=-=-=-==-=-=-=-=-=-=-=--=-=-=-=-==-=-=-==-=-=-=-==-=-=-=-=-=-=-=--=-=-=-=-=
    This class loads the connection stirng and will have (TODO) methods to laod and save data to our database.
    This class is NOT completed (for more info and information on how to use it, see: https://www.youtube.com/watch?v=ayp3tHEkRc0 

    METHODS TO SAVE AND LAOD DATA MUST BE CHANGED
    =-=-=-==-=-=-=-==-=-=-=-=-=-=-=--=-=-=-=-==-=-=-==-=-=-=-==-=-=-=-=-=-=-=--=-=-=-=-=*/
    public class SqlDataAccess
    {
        public static List<User> LoadData<User>()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var querySet = cnn.Query<User>("select * from User", new DynamicParameters());
                return querySet.ToList();
            }
        }

        public static void SaveData<User>()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into User (username, master_password) values (db_test, db_test_psw)");
            }
        }
        
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
