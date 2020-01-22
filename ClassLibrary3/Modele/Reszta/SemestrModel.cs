using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3.Modele.Reszta
{
    public class SemestrModel
    {
        /// <summary>
        /// unique identifier for a given Semester
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// represents Current semester:  
        /// </summary>
        public int Current { get; set; }



        public List<string> przedmioty = new List<string>();
      
    }
}
