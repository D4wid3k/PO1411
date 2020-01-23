using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary3.Modele.Ludzie;
using ClassLibrary3.Modele.Reszta;
using ClassLibrary3;

namespace Dziekanat
{
    public partial class WysylanieWniosku : Form
    {
        StudentModel dummy_student = new StudentModel();
        WniosekModel output = new WniosekModel();
        public WysylanieWniosku()
        {
            InitializeComponent();
        }

        private void Wyslij_Click(object sender, EventArgs e)
        {
            dummy_student.Id = 1;
            output.zawartosc = richTextBox1.Text;
            output = GlobalConfig.Connections.DodajWniosek(output);
            GlobalConfig.Connections.PrzypisanieFormularza(dummy_student.Id, output.Id);
        }
    }
}
