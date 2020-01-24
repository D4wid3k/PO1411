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
    public partial class ZmienOceny : Form
    {
        List<OcenaModel> Subjects = new List<OcenaModel>();
        List<OcenaModel> Ocena = new List<OcenaModel>();
        List<GrupaModel> Grupy = GlobalConfig.Connections.ZaladujWszystkieGrupy();
        public PersonModel S { get; set; }
        public PersonModel p { get; set; }
        public OcenaModel O { get; set; }

        public ZmienOceny()
        {
            InitializeComponent();
            WireUp();
        }


        List<string> Przedmioty = new List<string>();
        List<double> oceny = new List<double>();
        GrupaModel G { get; set; }

        List<StudentModel> Wybrani = new List<StudentModel>();
        List<StudentModel> Czlonkowie = new List<StudentModel>();

        void WireUp()
        {
            WybGruCombobox.DataSource = Grupy;
            WybGruCombobox.DisplayMember = "NazwaGr";

     
            //oceny
            oceny.Add(0);
            oceny.Add(2);
            oceny.Add(2.5);
            oceny.Add(3);
            oceny.Add(3.5);
            oceny.Add(4);
            oceny.Add(4.5);
            oceny.Add(5);


            OcenaCombobox.DataSource = oceny;
           

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
        
        private void ZobaczOcenyButton_Click(object sender, EventArgs e)
        {

            StudentModel S = (StudentModel)ListaStudListbox.SelectedItem;
            Subjects = GlobalConfig.Connections.ZaladujOceny(S);

            OcenyListbox.DisplayMember = null;
            
            OcenyListbox.DataSource = Subjects;
            OcenyListbox.DisplayMember = "Full_inf";
        }

        private void Wybierz_Click(object sender, EventArgs e)
        {
            O = (OcenaModel)OcenyListbox.SelectedItem;
            Ocena.Add(O);
            WybranaOcenaListBox.DisplayMember = null;
            WybranaOcenaListBox.DataSource = Ocena;
            WybranaOcenaListBox.DisplayMember = "Full_inf";

        }

        private void ZmienOceneButton_Click(object sender, EventArgs e)
        {
            O.Wartosc = (double)OcenaCombobox.SelectedItem;
            //GlobalConfig.Connections.ZmienOcene(O);
            Ocena.Remove(O);
            MessageBox.Show("Ocena zostala zmieniona");
            WybranaOcenaListBox.DataSource = Ocena;
            WybranaOcenaListBox.DisplayMember = "Wartosc";

        }



        private void PowrotButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }









        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ZmienOceny_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void WybGrupCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListaStudLabel_Click(object sender, EventArgs e)
        {

        }

        private void WypStudListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void WybranaOcenaListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void WybStudLabel_Click(object sender, EventArgs e)
        {

        }

        private void OcenaLabel_Click(object sender, EventArgs e)
        {

        }

       
    }
}
