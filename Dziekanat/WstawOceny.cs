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
        List<PrzedmiotModel> Dostep = new List<PrzedmiotModel>();

        List<GrupaModel> Grupy = GlobalConfig.Connections.ZaladujWszystkieGrupy();
     
      
        List<string> Przedmioty = new List<string>();
        List<double> oceny = new List<double>();
        GrupaModel G { get; set; }

        List<StudentModel> Wybrani = new List<StudentModel>();
        List<StudentModel> Czlonkowie = new List<StudentModel>();


       


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

        private void WybGruZatwButton_Click(object sender, EventArgs e)
        {
            Czlonkowie = new List<StudentModel>();
            GrupaModel G = null;
            
            G = (GrupaModel)WybGruCombobox.SelectedItem;
            Czlonkowie = GlobalConfig.Connections.ZaladujCzlonkowGrupy(G);

            ListaStudListbox.DataSource = Czlonkowie;
            ListaStudListbox.DisplayMember = "Full_Name_plus_Id";
        }

        private void DodStudButton_Click(object sender, EventArgs e)
        {
            WypStudListbox.DisplayMember = null;
            StudentModel s = (StudentModel)ListaStudListbox.SelectedItem;
            Wybrani.Add(s);
            WypStudListbox.DataSource = Wybrani;
            WypStudListbox.DisplayMember = "Full_Name_plus_Id";
        }

        private void UsunStudButton_Click(object sender, EventArgs e)
        {
            WypStudListbox.DisplayMember = null;
            StudentModel s = (StudentModel)WypStudListbox.SelectedItem;

            if(s!=null)
            {
                Wybrani.Remove(s);
                WypStudListbox.DataSource = Wybrani;
                WypStudListbox.DisplayMember = "Full_Name_plus_Id";
            }

        }

        private void DodOcenButton_Click(object sender, EventArgs e)
        {
            if (Wybrani.Count != 0)
            {
                OcenaModel O = new OcenaModel();
                O.Przedmiot = (string)PrzedmiotCombobox.SelectedItem;
                O.Wartosc = (double)OcenaCombobox.SelectedItem;
                O.Prowadzacy = p.Full_Name;
                O.data = DateTime.Today;

                O = GlobalConfig.Connections.StworzOcene(O);

                foreach (StudentModel S in Wybrani)
                {
                    PosiadaczOceny PO = new PosiadaczOceny();
                    PO.OsobaId = S.Id;
                    PO.OcenaId = O.Id;

                    GlobalConfig.Connections.StworzPosiadaczaOceny(PO);
                }

               

                MessageBox.Show("Oceny zostały dodane pomyslnie");

                //cleaning 
                Wybrani = new List<StudentModel>();
                WypStudListbox.DisplayMember = null;
                WypStudListbox.DataSource = Wybrani;
                WypStudListbox.DisplayMember = "FullName_plus_Id";
            }
            else
            {
                MessageBox.Show("Musisz wybrac przynajmniej jednego ucznia");
            }
        }


        private void PowrotButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void WstawOceny_Load(object sender, EventArgs e)
        {

        }

       
    }
}
