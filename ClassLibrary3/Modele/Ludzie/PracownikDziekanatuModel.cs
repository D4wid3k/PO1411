using ClassLibrary3.Modele.Reszta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3.Modele.Ludzie
{
    class PracownikDziekanatuModel : PracowanikUczelniModel
    {
        /// <summary>
        /// List of application's that one's has recived 
        /// </summary>
        public List<FormularzPracyDypModel> Formularze { set; get; }

        public void Ustalenie_Planu_Zajec()
        {
            //TODO - define 
        }

        public void Stworz_Grupe()
        {
            //TODO - define Stworz_Grupe
        }

        public void Sprawdzanie_Pop_Form(int odp)
        {
            //TODO - define  Sprawdzanie_Pop_Form
        }

    }
}
