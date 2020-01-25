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
        public FormularzZobacz(WniosekModel model)
        {
            {
                InitializeComponent();

                WireUpLists(model);
            }
        }

        private void ZaakceptujButton_Click(object sender, EventArgs e)
        {

        }

        void WireUpLists(WniosekModel model)
        {
            WniosekTextBox.Text = model.zawartosc;
        }

        private void OdrzucButton_Click(object sender, EventArgs e)
        {

        }
    }
}
