using ClassLibrary3.Modele.Reszta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3.Modele.Ludzie
{
    public class PersonModel
    {
        /// <summary>
        /// unique identifier for a given person
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// represents persons name 
        /// </summary>
        public string Imie { get; set; }

        /// <summary>
        /// represents person's surname
        /// </summary>
        public string Nazwisko { get; set; }

        /// <summary>
        /// represents person's PESEL
        /// </summary>
        public string PESEL { get; set; }

        /// <summary>
        /// represents email address
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// represents phone number
        /// </summary>
        public string NrTel { get; set; }

        /// <summary>
        /// represents password
        /// </summary>
        public string Haslo { get; set; }
        /// <summary>
        /// email
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// gets firstname and surname
        /// </summary>
        public string Full_Name
        {
            get
            {
                return $"{Imie} {Nazwisko}";
            }
        }

        /// <summary>
        /// represents user type: 0-student etc.. -- it provides different lvls of access
        /// </summary>
        public int UserType { get; set; }

        public List<PrzedmiotModel> Schedule { get; set; } = new List<PrzedmiotModel>();
    }
}
