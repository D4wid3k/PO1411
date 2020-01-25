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
    public partial class Oceny : Form
    {
        List<OcenaModel> Subjects = new List<OcenaModel>();

        List<OcenaModel> AISD = new List<OcenaModel>();
        List<OcenaModel> WF = new List<OcenaModel>();
        List<OcenaModel> PO = new List<OcenaModel>();
        List<OcenaModel> Algebra = new List<OcenaModel>();
        List<OcenaModel> Fiz = new List<OcenaModel>();

        double AISD_avg;
        double PO_avg;
        double Algebra_avg;
        double Fiz_avg;
        double WF_avg;

        List<double> F = new List<double>();
        List<double> A = new List<double>();
        List<double> W = new List<double>();
        List<double> P = new List<double>();
        List<double> Al = new List<double>();

        PersonModel p { get; set; }

        public Oceny(PersonModel model)
        {
            p = model;
            InitializeComponent();

            Subjects = GlobalConfig.Connections.ZaladujOceny(p);

            Sort();
            LoadLists();
            AVG();
        }

      

        void Sort()
        {
            //sort
            if (Subjects != null)
            {
                foreach (OcenaModel M in Subjects)
                {
                    if (M.Przedmiot == "AISD")
                    {
                        AISD.Add(M);
                    }
                    if (M.Przedmiot == "Algebra")
                    {
                        Algebra.Add(M);
                    }
                    if (M.Przedmiot == "Fiz")
                    {
                        Fiz.Add(M);
                    }
                    if (M.Przedmiot == "WF")
                    {
                        WF.Add(M);
                    }
                    if (M.Przedmiot == "PO")
                    {
                        PO.Add(M);
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
            ///Marks
            //Math
            AisdOcenyListbox.DataSource = AISD;
            AisdOcenyListbox.DisplayMember = null;
            AisdOcenyListbox.DisplayMember = "Wartosc";

            //History
            AlgebOcenyListbox.DataSource = Algebra;
            AlgebOcenyListbox.DisplayMember = null;
            AlgebOcenyListbox.DisplayMember = "Wartosc";

            //PE
            ProgrObiektOcenyListbox.DataSource = PO;
            ProgrObiektOcenyListbox.DisplayMember = null;
            ProgrObiektOcenyListbox.DisplayMember = "Wartosc";

            //Eng
            FizOcenyListbox.DataSource = Fiz;
            FizOcenyListbox.DisplayMember = null;
            FizOcenyListbox.DisplayMember = "Wartosc";

            WfOcenyListbox.DataSource = WF;
            WfOcenyListbox.DisplayMember = null;
            WfOcenyListbox.DisplayMember = "Wartosc";
        }

        void AVG()
        {
            List<double> helper = new List<double>();

            //AISD
            if (AISD.Count != 0)
            {
                foreach (OcenaModel m in AISD)
                {
                    helper.Add(m.Wartosc);
                }
                AISD_avg = helper.Average();
                A.Add(AISD_avg);
                helper = new List<double>();
            }
            else if (AISD.Count == 0)
            {
                A.Add(0);
            }

            //Algebra
            if (Algebra.Count != 0)
            {
                foreach (OcenaModel m in Algebra)
                {
                    helper.Add(m.Wartosc);
                }
                Algebra_avg = helper.Average();
                Al.Add(Algebra_avg);
                helper = new List<double>();
            }
            else if (Algebra.Count == 0)
            {
                Al.Add(0);
            }

            //PO
            if (PO.Count != 0)
            {
                foreach (OcenaModel m in PO)
                {
                    helper.Add(m.Wartosc);
                }
                PO_avg = helper.Average();
                P.Add(PO_avg);
                helper = new List<double>();
            }
            else if (PO.Count == 0)
            {
                P.Add(0);
            }

            //Fiz
            if (Fiz.Count != 0)
            {
                foreach (OcenaModel m in Fiz)
                {
                    helper.Add(m.Wartosc);
                }
                Fiz_avg = helper.Average();
                F.Add(Fiz_avg);
                helper = new List<double>();
            }
            else if (Fiz.Count == 0)
            {
                F.Add(0);
            }

            //WF
            if (WF.Count != 0)
            {
                foreach (OcenaModel m in WF)
                {
                    helper.Add(m.Wartosc);
                }
                WF_avg = helper.Average();
                W.Add(WF_avg);
                helper = new List<double>();
            }

            else if (WF.Count == 0)
            {
                W.Add(0);
            }




            showAVG();
        }

        void showAVG()
        {
            FizSredListbox.DataSource = F;
            AisdSredListbox.DataSource = A;
            WfSredListbox.DataSource = W;
            AlgebSredListbox.DataSource = Al;
            ProgrObiektSredListbox.DataSource = P;
        }


        private void PowrotButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AlgebSredListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}





  