using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3.Modele.Reszta
{
    public class PrzedmiotModel
    {

        /// <summary>
        /// unique identifier for a given Subject
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// represents subject's name
        /// </summary>
        public string Nazwa { get; set; }

        /// <summary>
        /// represents subject's name
        /// </summary>
        public double Czas { get; set; }

        /// <summary>
        /// represents subject's Day
        /// </summary>
        public string Dzien { get; set; }

        public string Full
        {
            get
            {
                return $"{Nazwa} {Czas}";
            }
        }
    }
}
