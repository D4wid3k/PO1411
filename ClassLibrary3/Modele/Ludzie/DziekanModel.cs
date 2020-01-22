using ClassLibrary3.Modele.Reszta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3.Modele.Ludzie
{
    public class DziekanModel : PracowanikUczelniModel
    {
        /// <summary>
        /// List of application's that one's has recived 
        /// </summary>
        public List<WniosekModel> Wnioski { get; set; }


        public void Rozpatrz_Wnioskow(int odp)
        {
            //TODO - define Rozpatrz_Wnioskow
        }

        public void Skreslenie_z_Listy()
        {
            //TODO - define Skreslenie_z_Listy
        }

        public void Stworz_Kierunek()
        {
            //TODO - define Stworz_Kierunek
        }

    }
}
