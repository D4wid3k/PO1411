using ClassLibrary3.DataAccess;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public static class GlobalConfig
    {
        /// <summary>
        /// dodaje do listy jakikolwiek element który implementuje ID 
        /// ataConnection
        /// </summary>  
        public static IDataConnection Connections { get; private set; }

        public static void InitializeConnections()
        {
            SQLConnector sql = new SQLConnector();
            //dodaje sql do listy połączeń
            Connections = sql;

            
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

       
    }
}
