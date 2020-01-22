using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary3;
using ClassLibrary3.Modele.Ludzie;
using ClassLibrary3.Modele.Reszta;
using Dapper;

namespace ClassLibrary3.DataAccess
{
    class SQLConnector : IDataConnection
    {

        //create
        public void DodajKierunek(KierunekModel kierunek)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Projekt_PO")))
            {
                var p = new DynamicParameters();
                p.Add("@Nazwa_kierunku", kierunek.Nazwa);
                p.Add("@Rok_rozpoczecia", kierunek.RokRozpoczecia);

                connection.Execute("dbo.spDodajKierunek", p, commandType: CommandType.StoredProcedure);

            }
        }
  



        //get
        public List<WniosekModel> PobierzWnioski()
        {
            List<WniosekModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Projekt_PO")))
            {

                output = connection.Query<WniosekModel>("dbo.spPobierzFormularze").ToList();

            }

            return output;
        }

        public PersonModel PersonGetByEmail(PersonModel model)
        {
            List<PersonModel> temp = new List<PersonModel>();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Projekt_PO")))
            {
                var p = new DynamicParameters();
                p.Add("@email", model.EmailAddress);
                temp = connection.Query<PersonModel>("dbo.spWysPoMail", p, commandType: CommandType.StoredProcedure).ToList();
            }

            if (temp.Count == 0)
            {
                return null;
            }
            else
            {
                foreach (PersonModel P in temp)
                {
                    model = P;
                }
            }

            return model;
        }

        public List<GrupaModel> ZaladujWszystkieGrupy()
        {
            throw new NotImplementedException();
        }






        //update






    }


}
