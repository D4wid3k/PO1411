using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3.Modele.Reszta
{
    public class PosiadaczOceny
    {
        /// <summary>
        /// unique identifier for a given mark owner
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// represents Mark;s Id
        /// </summary>
        public int OcenaId { get; set; }


        /// <summary>
        /// represents owner's(student) Id
        /// </summary>
        public int OsobaId { get; set; }
    }
}
