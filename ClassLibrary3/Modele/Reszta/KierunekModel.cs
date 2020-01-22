using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3.Modele.Reszta
{
    public class KierunekModel
    {
        /// <summary>
        /// unique identifier for a given FoS
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// represents FoS name e.g IO:  
        /// </summary>
        public string Nazwa { get; set; }

        /// <summary>
        /// represents start date  
        /// </summary>
        public string RokRozpoczecia { get; set; }

        /// <summary>
        /// List that contains class members
        /// </summary>
        public List<SemestrModel> Czlonkowie { get; set; } = new List<SemestrModel>();
    }
}
