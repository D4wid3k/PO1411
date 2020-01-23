using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3.Modele.Reszta
{
    class PosiadaczPrzedmiotu
    {
        /// <summary>
        /// unique identifier for a given  Subject owner
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// represents  Subject's Id
        /// </summary>
        public int PrzedmiotId { get; set; }


        /// <summary>
        /// represents owner's Id
        /// </summary>
        public int OsobaId { get; set; }
    }
}
