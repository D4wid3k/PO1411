﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3.Modele.Ludzie
{
    public class KandydatModel: PersonModel
    {
        public int WynikRekrutacyjny { get; set; }

        /// <summary>
        /// List of application's that one's has applied 
        /// </summary>
        public string KierunekDocelowy { get; set; }

        public void Rejestracja()
        {
            //TODO - define  Rejestracja
        }


    }
}
