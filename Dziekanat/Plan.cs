using ClassLibrary3;
using ClassLibrary3.Modele.Ludzie;
using ClassLibrary3.Modele.Reszta;
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
    public partial class Plan : Form
    {
        //Sechedule
        List<PrzedmiotModel> Schedule = new List<PrzedmiotModel>();
        List<PrzedmiotModel> Mon = new List<PrzedmiotModel>();
        List<PrzedmiotModel> Teu = new List<PrzedmiotModel>();
        List<PrzedmiotModel> Wed = new List<PrzedmiotModel>();
        List<PrzedmiotModel> Thu = new List<PrzedmiotModel>();
        List<PrzedmiotModel> Fr = new List<PrzedmiotModel>();
        public PersonModel p { get; set; }


        public Plan(PersonModel model)
        {
            p = model;
            Schedule = GlobalConfig.Connections.ZaladujPrzedmioty(p);
            InitializeComponent();

            Sort();
            LoadLists();
        }


        void Sort()
        {
            if(Schedule != null)
            {
                foreach (PrzedmiotModel S in Schedule)
                {
                    if (S.Dzien == "Pon")
                    {
                        Mon.Add(S);
                    }
                    if (S.Dzien == "Wt")
                    {
                        Teu.Add(S);
                    }
                    if (S.Dzien == "Sr")
                    {
                        Wed.Add(S);
                    }
                    if (S.Dzien == "Czw")
                    {
                        Thu.Add(S);
                    }
                    if (S.Dzien == "Pt")
                    {
                        Fr.Add(S);
                    }
                }
            }
            else
            {
                MessageBox.Show("NIE MA NIC ");
            }
          
        }

        void LoadLists()
        {
            ///Schedule
            //mon
            PonListbox.DataSource = Mon;
            PonListbox.DisplayMember = null;
            PonListbox.DisplayMember = "Full";

            //Teu
            WtoListbox.DataSource = Teu;
            WtoListbox.DisplayMember = null;
            WtoListbox.DisplayMember = "Full";

            //Wed
            SroListbox.DataSource = Wed;
            SroListbox.DisplayMember = null;
            SroListbox.DisplayMember = "Full";

            //Thu
            CzwListbox.DataSource = Thu;
            CzwListbox.DisplayMember = null;
            CzwListbox.DisplayMember = "Full";


            //Fr
            PiaListbox.DataSource = Fr;
            PiaListbox.DisplayMember = null;
            PiaListbox.DisplayMember = "Full";
        }






        //trash
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void PowrotButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PonListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
