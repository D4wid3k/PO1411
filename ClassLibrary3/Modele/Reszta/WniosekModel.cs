using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3.Modele.Reszta
{
    public class WniosekModel
    {
        /// <summary>
        /// unique identifier for a given application 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// doc.
        /// </summary>
        public string zawartosc { get; set; }
        

        /// <summary>
        /// shows title
        /// </summary>
        public string Title
        {
            get
            {

                string helper = "";
          
                for (int i = 0; i<5; i++)
                {
                    helper+=zawartosc[i];
                    
                }
                return $"{helper}...";
            }
        }

    }
}
