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


        //get
        List<WniosekModel> PobierzWnioski();
        PersonModel PersonGetByEmail(PersonModel model);


        //update

    }
}
