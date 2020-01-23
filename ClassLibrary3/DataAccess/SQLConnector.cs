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
        public void DodajKandydata(KandydatModel kandydat)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Projekt_PO")))
            {
                var p = new DynamicParameters();
                p.Add("@imie", kandydat.Imie);
                p.Add("@nazwisko", kandydat.Nazwisko);
                p.Add("@email", kandydat.EmailAddress);
                p.Add("@usertype", kandydat.UserType);
                p.Add("@PESEL", kandydat.PESEL);
                p.Add("@haslo", kandydat.Haslo);
                p.Add("@wynik_rekrutacyjny", kandydat.WynikRekrutacyjny);

                connection.Execute("dbo.spDodajKandydata", p, commandType: CommandType.StoredProcedure);

            }
        }

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

        public WniosekModel DodajWniosek(WniosekModel wniosek)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Projekt_PO")))
            {
                var p = new DynamicParameters();
                p.Add("@Zawartosc", wniosek.zawartosc);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spDodajFormularz", p, commandType: CommandType.StoredProcedure);

                wniosek.Id = p.Get<int>("@id");

                return wniosek;
            }
        }

        public List<WniosekModel> PobierzWnioski()
        {
            List<WniosekModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Projekt_PO")))
            {

                output = connection.Query<WniosekModel>("dbo.spPobierzFormularze").ToList();

            }

            return output;
        }

        public void PrzypisanieFormularza(int ID_User, int ID_Wniosku)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Projekt_PO")))
            {
                var p = new DynamicParameters();
                p.Add("@IDStud", ID_User);
                p.Add("@IDform", ID_Wniosku);

                connection.Execute("dbo.spDodajPrzypisanieForm", p, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
