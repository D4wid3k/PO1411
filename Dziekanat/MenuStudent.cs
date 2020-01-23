﻿using ClassLibrary3.Modele.Ludzie;
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
            Plan pl = new Plan(p);
            pl.Show();
        }

        private void OcenyLabel_Click(object sender, EventArgs e)
        {
            Oceny oc = new Oceny(p);
            oc.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       
    }
}
