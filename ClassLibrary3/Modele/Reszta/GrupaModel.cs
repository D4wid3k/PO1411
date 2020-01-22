using ClassLibrary3.Modele.Ludzie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3.Modele.Reszta
{
    public class GrupaModel
    {
        /// <summary>
        /// unique identifier for a given class
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// represents class's name e.g gr 2 lab:  
        /// </summary>
        public string NazwaGr { get; set; }

        /// <summary>
        /// List that contains class members
        /// </summary>
        public List<PersonModel> Czlonkowie { get; set; } = new List<PersonModel>();
    }
}
