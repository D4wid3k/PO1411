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
                p.Add("@Rok_rozpoczecia", kierunek.rok_rozpoczecia);

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

        public OcenaModel StworzOcene(OcenaModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Projekt_PO")))
            {
                var p = new DynamicParameters();
                p.Add("@Wartosc", model.Wartosc);
                p.Add("@Przedmiot", model.Przedmiot);
                p.Add("@Prowadzacy", model.Prowadzacy);
                p.Add("@Data", model.data);


                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spDodajOcene", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                return model;
            }
        }

        public PosiadaczOceny StworzPosiadaczaOceny(PosiadaczOceny model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Projekt_PO")))
            {
                var p = new DynamicParameters();
                p.Add("@OsobaId", model.OsobaId);
                p.Add("@OcenaId", model.OcenaId);


                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spDodajPosiadaczOceny", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                return model;
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
            List<GrupaModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Projekt_PO")))
            {
                output = connection.Query<GrupaModel>("dbo.spWysIDiNazwaGrup").ToList();

                foreach (GrupaModel G in output) //Get members by class id 
                {
                    var p = new DynamicParameters();
                    p.Add("@IDgr", G.Id);
                    G.Czlonkowie = connection.Query<PersonModel>("dbo.spWysWszysStudent", p, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            return output;
        }

        public List<PrzedmiotModel> ZaladujDostepnePrzedmioty(PersonModel model)
        {
            List<PrzedmiotModel> Dostep = new List<PrzedmiotModel>();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Projekt_PO")))
            {
                var p = new DynamicParameters();
                p.Add("@ID", model.Id);
                Dostep = connection.Query<PrzedmiotModel>("dbo.spWysDostepnePrzedmiotyPoID", p, commandType: CommandType.StoredProcedure).ToList();
            }

            if (Dostep.Count == 0)
            {
                return null;
            }



            return Dostep;
        }

        public List<PrzedmiotModel> ZaladujPrzedmioty(PersonModel model)
        {
            List<PrzedmiotModel> Dostep = new List<PrzedmiotModel>();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Projekt_PO")))
            {
                var p = new DynamicParameters();
                p.Add("@ID", model.Id);
                Dostep = connection.Query<PrzedmiotModel>("dbo.spWysPrzPoMail", p, commandType: CommandType.StoredProcedure).ToList();
            }

            if (Dostep.Count == 0)
            {
                return null;
            }



            return Dostep;
        }
        
        public List<StudentModel> ZaladujCzlonkowGrupy(GrupaModel model)
        {
            List<StudentModel> temp = new List<StudentModel>();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Projekt_PO")))
            {
                var p = new DynamicParameters();
                p.Add("@ID", model.Id);
                temp = connection.Query<StudentModel>("dbo.spWysOsobyPoIDGrupy", p, commandType: CommandType.StoredProcedure).ToList();
            }
            
            return temp;
        }

        public List<OcenaModel> ZaladujOceny(PersonModel model)
        {
            List<OcenaModel> Oceny = new List<OcenaModel>();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Projekt_PO")))
            {
                var p = new DynamicParameters();
                p.Add("@IDst", model.Id);
                Oceny = connection.Query<OcenaModel>("dbo.spWysOcenyPoID", p, commandType: CommandType.StoredProcedure).ToList();
            }

            if (Oceny.Count == 0)
            {
                return null;
            }



            return Oceny;
        }


        //update

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

        public List<KierunekModel> ZaładujWszystkieKierunki()
        {
            List<KierunekModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Projekt_PO")))
            {

                output = connection.Query<KierunekModel>("dbo.spWysWszystkichKierunkow").ToList();

            }

            return output;
        }

        public void PrzypisanieKIerunekDoUcznia(int ID_User, int ID_Kierunek)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Projekt_PO")))
            {
                var p = new DynamicParameters();
                p.Add("@IDUcznia", ID_User);
                p.Add("@IDKierunek", ID_Kierunek);

                connection.Execute("dbo.spDodajUczIKier", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void ZmienOcene(OcenaModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Projekt_PO")))
            {
                var p = new DynamicParameters();
                p.Add("@Id", model.Id);
                p.Add("@Wartosc", model.Wartosc);
                connection.Execute("dbo.spZmianaOceny", p, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
