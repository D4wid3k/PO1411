using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3.Modele.Reszta
{
    public class OcenaModel
    {

        /// <summary>
        /// unique identifier for a given mark
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// represents subject's name (MarkModel)
        /// </summary>
        public string Przedmiot { get; set; }


        /// <summary>
        /// represents mark's value 
        /// </summary>
        public double Wartosc { get; set; }


        /// <summary>
        /// represents Teacher that added new mark
        /// </summary>
        public string Prowadzacy { get; set; }


        /// <summary>
        /// represents Date of mark's addition
        /// </summary>
        public DateTime data { get; set; }

    }
}
