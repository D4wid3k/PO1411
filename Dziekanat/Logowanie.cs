using ClassLibrary3;
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
    public partial class Logowanie : Form
    {
        PersonModel p = new PersonModel();

        public Logowanie()
        {
            InitializeComponent();
        }

        void Read()
        {
            p.EmailAddress = LoginTextbox.Text;
            p.Haslo = HasloTextbox.Text;
        }

        void Clean()
        {
            p = new PersonModel();
            LoginTextbox.Text = null;
            HasloTextbox.Text = null;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Read();
            p = GlobalConfig.Connections.PersonGetByEmail(p);

            if (p == null)
            {
                MessageBox.Show("Wrong e-mail address please try again");
            }
            else
            {
                if (p.Haslo != HasloTextbox.Text)
                {
                    MessageBox.Show("Wrong password please try again");
                }
                else
                {
                    if (p.UserType == 1)
                    {
                        MenuStudent ms = new MenuStudent(p);
                        ms.Show();
                    }
                    else if (p.UserType == 2)
                    {
                        MenuPracownik mp = new MenuPracownik(p);
                        mp.Show();
                    }
                    else if (p.UserType == 3)
                    {
                        MenuDziekan md = new MenuDziekan(p);
                        md.Show();
                    }
                }
            }
            Clean();
        }

        private void RejestracjaButton_Click(object sender, EventArgs e)
        {
            Rejestracja r = new Rejestracja();
            r.Show();
        }
    }
}
