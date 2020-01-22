using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary3.Modele;
using ClassLibrary3;
using ClassLibrary3.Modele.Reszta;


namespace ClassLibrary3.DataAccess
{
    public interface IDataConnection
    {
        List<WniosekModel> PobierzWnioski();
        void DodajKierunek(KierunekModel kierunek);
    }
}
