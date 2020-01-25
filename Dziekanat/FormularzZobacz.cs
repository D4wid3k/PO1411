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
    public partial class FormularzZobacz : Form
    {
        WniosekModel p = new WniosekModel();
        public FormularzZobacz(WniosekModel model)
        {
            {
                InitializeComponent();
                p = model;
                WireUpLists(p);
            }
        }

        private void ZaakceptujButton_Click(object sender, EventArgs e)
        {
            p.Stan = 1;

            GlobalConfig.Connections.zmienstatus(p);

            this.Close();
        }

        private void OdrzucButton_Click(object sender, EventArgs e)
        {
            p.Stan = 2;

            GlobalConfig.Connections.zmienstatus(p);

            this.Close();
        }

        void WireUpLists(WniosekModel p)
        {
            WniosekTextBox.Text = p.zawartosc;
        }

      
    }
}
