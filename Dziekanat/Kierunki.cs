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
    public partial class Kierunki : Form
    {
        private List<KierunekModel> DostepneKierunki = new List<KierunekModel>();
        public Kierunki()
        {
            InitializeComponent();

            zaladuj_liste();

            WireUpLists();
        }

        private void zaladuj_liste()
        {
            DostepneKierunki = GlobalConfig.Connections.ZaładujWszystkieKierunki();
        }

        private void WireUpLists()
        {
            KierListbox.DataSource = null;

            KierListbox.DataSource = DostepneKierunki;
            KierListbox.DisplayMember = "FullName";
        }

        private void StworzKierButton_Click(object sender, EventArgs e)
        {

        }
    }
}
