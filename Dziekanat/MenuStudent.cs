using ClassLibrary3.Modele.Ludzie;
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
    public partial class MenuStudent : Form
    {
        public PersonModel p { get; set; }

        public MenuStudent(PersonModel model)
        {
            p = model;
            InitializeComponent();
        }

        private void PlanLabel_Click(object sender, EventArgs e)
        {
            (new Plan(p)).Show();
        }

        private void OcenyLabel_Click(object sender, EventArgs e)
        {
            (new Oceny(p)).Show();
        }

        private void WylogujButton_Click(object sender, EventArgs e)
        {
            this.Close();
            (new Logowanie()).Show();
        }

        private void WyslijWniosekButton_Click(object sender, EventArgs e)
        {
            (new WysylanieWniosku(p)).Show();
        }
    }
}
