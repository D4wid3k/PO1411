using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary3;
using ClassLibrary3.Modele.Reszta;
using Dapper;

namespace ClassLibrary3.DataAccess
{
    class SQLConnector : IDataConnection
    {
        public List<WniosekModel> PobierzWnioski()
        {
            List<WniosekModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Projekt_PO")))
            {

                output = connection.Query<WniosekModel>("dbo.spPobierzFormularze").ToList();

            }

            return output;
        }
    }
}
