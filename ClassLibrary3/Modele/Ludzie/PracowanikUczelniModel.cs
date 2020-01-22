using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3.Modele.Ludzie
{
    class PracowanikUczelniModel : PersonModel
    {
        /// <summary>
        ///  List of subjects that one is teaching   
        /// </summary>
        public List<string> DostepDoPrzedmiotow { get; set; }

        public void Wprowadzenie_Oceny()
        {
            //TODO - define  Wprowadzenie_Oceny
        }

        public void Zmiana_Oceny()
        {
            //TODO - define Zmiana_Oceny
        }

    }
}
