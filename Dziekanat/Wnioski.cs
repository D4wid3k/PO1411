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
using ClassLibrary3.Modele.Reszta;

namespace Dziekanat
{  
    public partial class Wnioski : Form
    {
        private List<WniosekModel> _Wnioski = new List<WniosekModel>();
        //private List<WniosekModel> temp = new List<WniosekModel>();
        public Wnioski()
        {
            InitializeComponent();

            zaladuj_liste();

            WireUpLists();
        }

       
        private void UsunWniosekButton_Click(object sender, EventArgs e)
        {
            new FormularzZobacz((WniosekModel)ListaWnioskowListbox.SelectedItem).Show();
          
        }

      



        private void zaladuj_liste()
        {
           
             List<WniosekModel> temp = GlobalConfig.Connections.PobierzWnioski();
           

            foreach (WniosekModel wm in temp)
            {
                if(wm.Stan == 0)
                {
                    _Wnioski.Add(wm);
                }
            }
        }

        private void WireUpLists()
        {

            /* LekarzeListBox.DataSource = allLekarzUsers;
             LekarzeListBox.DisplayMember = "FullName";*/

            ListaWnioskowListbox.DataSource = null;
            ListaWnioskowListbox.DataSource = _Wnioski;
            ListaWnioskowListbox.DisplayMember = "Title";

        }

        private void Wnioski_Load(object sender, EventArgs e)
        {

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            _Wnioski = null;
            zaladuj_liste();
            WireUpLists();
        }
    }
}
