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
using ClassLibrary3.Modele.Reszta;

namespace Dziekanat
{
    public partial class ZakonczRekrutacje : Form
    {
        List<KierunekModel> ListaKierunkow = new List<KierunekModel>();
        List<KierunekModel> sorted_ListaKierunkow = new List<KierunekModel>();

        public ZakonczRekrutacje()
        {
            InitializeComponent();

            zaladuj_liste();

            sortuj();

            WireUpLists();
        }

        private void RekrutacjaButton_Click(object sender, EventArgs e)
        {
            KierunekModel wydostan = (KierunekModel)KierunkiCombobox.SelectedItem;
            WybranyKieunekLabel.Text = wydostan.Nazwa;
        }

        private void zaladuj_liste()
        {
            ListaKierunkow = GlobalConfig.Connections.ZaładujWszystkieKierunki();
        }

        private void WireUpLists()
        {
            KierunkiCombobox.DataSource = null;

            KierunkiCombobox.DataSource = sorted_ListaKierunkow;
            KierunkiCombobox.DisplayMember = "Nazwa";
        }

        private void sortuj()
        {
            var src = DateTime.Now;

            foreach (KierunekModel kierunek in ListaKierunkow)
            {
                if (System_Obliczenia.zmien_string_na_int(kierunek.rok_rozpoczecia) == src.Year)
                {
                    sorted_ListaKierunkow.Add(kierunek);
                }
            }
        }


    }
}
