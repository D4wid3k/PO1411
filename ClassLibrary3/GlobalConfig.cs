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
      

        public static DataConnectionsInterface Connection { get; private set; }
        //każdy moze przeczytać wartość połączęń -> {get}
        //ale tylko w metodach można zmienić ich wartość -> {private set}


        public static void InitializeConnections(DatabaseType db)
        {
            if (db == DatabaseType.Sql)
            {
                SQLConnector sql = new SQLConnector();
                Connection = sql;
            }
            else
            {
                Console.WriteLine("invalid Database type -__-");
            }
        }

        /// <summary>
        /// SQL server shit
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string CnnString(string name) //zajrzy do App.config, wyszuka WU (jeśli to wpiszesz) i pobierze: Server=LAPT...sted_Connection = True
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
