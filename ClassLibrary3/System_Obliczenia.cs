using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public class System_Obliczenia
    {
        public static int zmien_string_na_int(string pkt)
        {
            int output = 0;
            int licznik = pkt.Length;
            foreach (char litera in pkt)
            {
                output += ((int)litera - 48) * (int)Math.Pow(10, licznik);
                licznik--;
            }

            return output / 10;
        }
    }
}
