using ClassLibrary3.Modele.Ludzie;
using ClassLibrary3.Modele.Reszta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3.Modele.Ludzie
{
    class StudentModel : PersonModel
    {
        /// <summary>
        /// Person local ID (in calss) {int} -- names ordered by alphabet 
        /// </summary>
        public int LocalneId { get; set; }

        public List<OcenaModel> Oceny { get; set; } = new List<OcenaModel>();

        public int ECTS { get; set; } 

        public string Kierunek { get; set; }

        public int Semestr { get; set; }
        
        public string Full_Name_plus_Id
        {
            get
            {
                return $"{LocalneId}. {Imie} {Nazwisko}";
            }
        }
    }
}
