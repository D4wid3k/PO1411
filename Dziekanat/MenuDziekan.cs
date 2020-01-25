using ClassLibrary3.Modele.Ludzie;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dziekanat
{
    public partial class MenuDziekan : Form
    {

        public PersonModel person { get; set; }

        public MenuDziekan(PersonModel model)
        {
            InitializeComponent();
            person = model;
        }

        private void KierunkiButton_Click(object sender, EventArgs e)
        {
            new Kierunki().Show();
        }

        private void WnioskiButton_Click(object sender, EventArgs e)
        {
            new Wnioski().Show();
        }

        private void WylogujButton_Click(object sender, EventArgs e)
        {
            this.Close();
            (new Logowanie()).Show();
        }

        private void RekrutacjaButton_Click(object sender, EventArgs e)
        {
            (new ZakonczRekrutacje()).Show();
        }
    }
}
