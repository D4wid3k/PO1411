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
        List<WniosekModel> PobierzWnioski();
        void DodajKierunek(KierunekModel kierunek);
        void DodajKandydata(KandydatModel kandydat);
        WniosekModel DodajWniosek(WniosekModel wniosek);
        void PrzypisanieFormularza(int ID_User, int ID_Wniosku);
    }
}
