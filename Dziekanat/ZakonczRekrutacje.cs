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
        List<KandydatModel> WszyscyKandydaci = new List<KandydatModel>();
        List<KandydatModel> Kandydat_SortedList = new List<KandydatModel>();
        List<KandydatModel> Kandydaci_przyjęci = new List<KandydatModel>();
        List<KandydatModel> Kandydaci_odrzuceni = new List<KandydatModel>();
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
            WszyscyKandydaci = GlobalConfig.Connections.ZaladujKandydatowNaKierunek(wydostan.Nazwa);
            Kandydat_SortedList = WszyscyKandydaci.OrderByDescending(o => o.WynikRekrutacyjny).ToList();

            if (Kandydat_SortedList.Count < wydostan.ilosc_miejsc)
            {
                Kandydaci_przyjęci = Kandydat_SortedList;
            }
            else
            {
                for (int i = 0; i < wydostan.ilosc_miejsc; i++)
                {
                    Kandydaci_przyjęci.Add(Kandydat_SortedList[i]);
                }
                for (int i = wydostan.ilosc_miejsc; i < Kandydat_SortedList.Count; i++)
                {
                    Kandydaci_odrzuceni.Add(Kandydat_SortedList[i]);
                }
            }

            GlobalConfig.Connections.Zarekrutuj(Kandydaci_przyjęci);


            WireUpLists();

        }

        private void zaladuj_liste()
        {
            ListaKierunkow = GlobalConfig.Connections.ZaładujWszystkieKierunki();
        }

        private void WireUpLists()
        {
            KierunkiCombobox.DataSource = sorted_ListaKierunkow;
            KierunkiCombobox.DisplayMember = "Nazwa";



            ZakwalifikowaniListBox.DataSource = Kandydaci_przyjęci;
            ZakwalifikowaniListBox.DisplayMember = "Full_Name";
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

        //TODO - sortowac po ilosci pkt i wpisac do listy tych co sb dostali i ich po ID znajdowac 
        //i zmieniac status z 0 na 1 i semestr na 1 
        //a tych co są na dole usuwamy :)

    }
}
