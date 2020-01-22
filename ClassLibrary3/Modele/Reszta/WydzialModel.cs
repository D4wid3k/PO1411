using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3.Modele.Reszta
{
    public class WydzialModel
    {
        /// <summary>
        /// unique identifier for a given faculty
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// represents faluty's name e.g wiimip:  
        /// </summary>
        public string Nazwa { get; set; }

    }
}
