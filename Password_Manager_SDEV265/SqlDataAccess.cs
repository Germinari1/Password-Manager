using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Manager_SDEV265
{
    /* =-=-=-==-=-=-=-==-=-=-=-=-=-=-=--=-=-=-=-==-=-=-==-=-=-=-==-=-=-=-=-=-=-=--=-=-=-=-=
    This class loads the connection stirng and will have (TODO) methods to laod and save data to our database.
    This class is NOT completed (for more info and information on how to use it, see: https://www.youtube.com/watch?v=ayp3tHEkRc0 
    =-=-=-==-=-=-=-==-=-=-=-=-=-=-=--=-=-=-=-==-=-=-==-=-=-=-==-=-=-=-=-=-=-=--=-=-=-=-=*/

    public class SqlDataAccess
    {
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
