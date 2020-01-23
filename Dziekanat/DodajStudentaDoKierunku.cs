using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary3.Modele.Reszta;
using ClassLibrary3;

namespace Dziekanat
{
    public partial class DodajStudentaDoKierunku : Form
    {
        private KierunekModel Kierunek_przypisz = new KierunekModel();
        public DodajStudentaDoKierunku(KierunekModel _Kierunek)
        {
            InitializeComponent();

            Kierunek_przypisz = _Kierunek;
        }

        private void KierHeader_Click(object sender, EventArgs e)
        {

        }

        private void DodajStudButton_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                int userID = zmien_string_na_int(WpiszIDTextbox.Text);

                GlobalConfig.Connections.PrzypisanieKIerunekDoUcznia(userID, Kierunek_przypisz.Id);

                WpiszIDTextbox.Text = "";
            }
            else
            {
                MessageBox.Show("Błędne dane");
            }

        }

        bool validate()
        {
            bool output = true;

            if (WpiszIDTextbox.Text == "")
            {
                output = false;
            }

            return output;
        }

        int zmien_string_na_int(string pkt)
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
