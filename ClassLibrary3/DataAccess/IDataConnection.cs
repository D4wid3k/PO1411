using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary3.Modele;
using ClassLibrary3;
using ClassLibrary3.Modele.Reszta;
using ClassLibrary3.Modele.Ludzie;

namespace ClassLibrary3.DataAccess
{
    public interface IDataConnection
    {
        //create
        OcenaModel StworzOcene(OcenaModel model);
        PosiadaczOceny StworzPosiadaczaOceny(PosiadaczOceny model);
        void DodajKierunek(KierunekModel kierunek);
        void DodajKandydata(KandydatModel kandydat);
        WniosekModel DodajWniosek(WniosekModel wniosek);
        void PrzypisanieFormularza(int ID_User, int ID_Wniosku);

        //get
        List<WniosekModel> PobierzWnioski();
        PersonModel PersonGetByEmail(PersonModel model);
        List<GrupaModel> ZaladujWszystkieGrupy();
        List<KierunekModel> ZaładujWszystkieKierunki();
        List<StudentModel> ZaladujCzlonkowGrupy(GrupaModel model);
        List<PrzedmiotModel> ZaladujDostepnePrzedmioty(PersonModel model);
        List<PrzedmiotModel> ZaladujPrzedmioty(PersonModel model);
        List<OcenaModel> ZaladujOceny(PersonModel model);
        void PrzypisanieKIerunekDoUcznia(int ID_User, int ID_Kierunek);


        //update


    }


    //void DodajKierunek(KierunekModel kierunek);
    //void DodajKandydata(KandydatModel kandydat);
    //WniosekModel DodajWniosek(WniosekModel wniosek);
    //void PrzypisanieFormularza(int ID_User, int ID_Wniosku);
}
