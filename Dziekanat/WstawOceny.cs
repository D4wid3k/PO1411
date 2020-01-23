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
    public partial class WstawOceny : Form
    {
        
        public PersonModel p { get; set; }
        public PracowanikUczelniModel u { get; set; }
        List<PrzedmiotModel> Dostep = new List<string>();

        List<GrupaModel> Grupy = GlobalConfig.Connections.ZaladujWszystkieGrupy();
        List<PersonModel> Czlonkowie = new List<PersonModel>();
        List<PersonModel> Wybrani = new List<PersonModel>();
        List<string> Przedmioty = new List<string>();
        List<double> oceny = new List<double>();

        public WstawOceny(PersonModel model)
        {
            p = model;
            Dostep = GlobalConfig.Connections.ZaladujDostepnePrzedmioty(p);
            InitializeComponent();
            WireUp();
        }



        void WireUp()
        {
            WybGruCombobox.DataSource = Grupy;
            WybGruCombobox.DisplayMember = "NazwaGr";

            //lists
            foreach(PrzedmiotModel D in Dostep)
            {
                if(D.Nazwa =="Fiz")
                {
                    Przedmioty.Add("Fiz");
                }
                if (D.Nazwa == "WF")
                {
                    Przedmioty.Add("WF");
                }
                if (D.Nazwa == "Algebra")
                {
                    Przedmioty.Add("Algebra");
                }
                if (D.Nazwa == "PO")
                {
                    Przedmioty.Add("PO");
                }
                if (D.Nazwa == "AISD")
                {
                    Przedmioty.Add("AISD");
                }
               
            }
           


            oceny.Add(0);
            oceny.Add(2);
            oceny.Add(2.5);
            oceny.Add(3);
            oceny.Add(3.5);
            oceny.Add(4);
            oceny.Add(4.5);
            oceny.Add(5);


           OcenaCombobox.DataSource = oceny;
           PrzedmiotCombobox.DataSource = Przedmioty;

        }














        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void WstawOceny_Load(object sender, EventArgs e)
        {

        }
    }
}
