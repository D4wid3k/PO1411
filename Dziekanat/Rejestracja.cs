using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary3;
using ClassLibrary3.Modele.Ludzie;

namespace Dziekanat
{
    public partial class Rejestracja : Form
    {
        public Rejestracja()
        {
            InitializeComponent();
        }
        private void ZarejestrujButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                KandydatModel user = new KandydatModel();
                user.Imie = ImieTextbox.Text;
                user.Nazwisko = NazwiskoTextbox.Text;
                user.EmailAddress = EmailTextbox.Text;
                user.UserType = 0;
                user.PESEL = PeselTextbox.Text;
                user.Haslo = HasloTextbox.Text;
                user.WynikRekrutacyjny = zmien_string_na_int(PunktyRekrTextbox.Text);
                //GlobalConfig.Connections.StworzUzytkownik(user);
                //GlobalConfig.Connections.Wstaw_haslo(haslo, GlobalConfig.Connections.Uzyskaj_Id_Wstawianego_Usera(user.PESEL));
                //MessageBox.Show($"imie{user.Imie} nazwisko{user.Nazwisko} email{user.EmailAddress} usertyp{user.UserType} pesel{user.PESEL} hasl{user.Haslo} wynik{user.WynikRekrutacyjny}");

                GlobalConfig.Connections.DodajKandydata(user);

                ImieTextbox.Text = "";
                NazwiskoTextbox.Text = "";
                EmailTextbox.Text = "";
                PeselTextbox.Text = "";
                HasloTextbox.Text = "";
                PunktyRekrTextbox.Text = "";
            }
            else
            {
                MessageBox.Show("Dane niepoprawne");
            }

            //ImieTextbox.Text = "";
        }
        private bool ValidateForm()
        {
            bool output = true;
            if (ImieTextbox.Text.Length == 0)
            {
                output = false;
            }
            if (NazwiskoTextbox.Text.Length == 0)
            {
                output = false;
            }
            if (EmailTextbox.Text.Length == 0)
            {
                output = false;
            }
            if (PeselTextbox.Text.Length == 0)
            {
                output = false;
            }
            if (HasloTextbox.Text.Length == 0)
            {
                output = false;
            }
            if (PunktyRekrTextbox.Text.Length == 0)
            {
                output = false;
            }
            return output;
        }
        int zmien_string_na_int(string pkt)
        {
            int output = 0;
            int licznik = pkt.Length;
            foreach(char litera in pkt)
            {
                output += ((int)litera - 48) * (int)Math.Pow(10, licznik);
                licznik--;
            }

            return output/10;
        }
    }
}
