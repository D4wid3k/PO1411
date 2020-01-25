using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary3.Modele.Ludzie;
using ClassLibrary3.Modele.Reszta;
using ClassLibrary3;

namespace Dziekanat
{
    public partial class WysylanieWniosku : Form
    {
       
        WniosekModel wniosek = new WniosekModel();

        PersonModel p = new PersonModel();


        public WysylanieWniosku(PersonModel model)
        {
            p = model;
            InitializeComponent();
        }

        private void Wyslij_Click(object sender, EventArgs e)
        {
            wniosek.zawartosc = richTextBox1.Text;

            wniosek = GlobalConfig.Connections.DodajWniosek(wniosek);
            GlobalConfig.Connections.PrzypisanieFormularza(p.Id, wniosek.Id);


            richTextBox1.Text = null;
            MessageBox.Show("Wniosek zostal wyslany");
        }
    }
}
