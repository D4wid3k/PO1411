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
    public partial class NowyKierunek : Form
    {
        public NowyKierunek()
        {
            InitializeComponent();
        }

        private void NowyKierunek_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StworzKierButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                KierunekModel kierunek = new KierunekModel();
                kierunek.Nazwa = NazwaKierTextbox.Text;
                kierunek.RokRozpoczecia = RokRozpTextbox.Text;

                GlobalConfig.Connections.DodajKierunek(kierunek);

            }
            else
            {
                MessageBox.Show("Dane niepoprawne");
            }

            NazwaKierTextbox.Text = "";
            RokRozpTextbox.Text = "";
        }

        private bool ValidateForm()
        {
            bool output = true;

            if (NazwaKierTextbox.Text.Length == 0)
            {
                output = false;
            }
            if (RokRozpTextbox.Text.Length == 0)
            {
                output = false;
            }

            return output;
        }
    }
}
