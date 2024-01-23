using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Notenplana23
{
    public partial class ViewLoggin : Form
    {
        private ModelLoggin modelLoggin;
        private ViewRegestrierung viewRegestrierung;
        private ViewHauptprogramm viewHauptprogramm;
        private ControllerProfile controllerProfil;

        public ViewRegestrierung ViewRegestrierung { get => viewRegestrierung; set => viewRegestrierung = value; }
        public ViewHauptprogramm ViewHauptprogramm { get => viewHauptprogramm; set => viewHauptprogramm = value; }
        internal ControllerProfile ControllerProfil { get => controllerProfil; set => controllerProfil = value; }

        public ViewLoggin()
        {
            InitializeComponent();
        }


        private void buttonRegestrieren_Click(object sender, EventArgs e)
        {
            //Die ViewRegistrierung ist schon in der Klasse programm
            //instanziiert!
            //Hier könnten immer neue Views den Speicher füllen.
            //ViewRegestrierung viewRegestrierung = new ViewRegestrierung();
            ViewRegestrierung.Show();

            this.Hide();
        }

        private void buttonLoggin_Click(object sender, EventArgs e)
        {
            //Die ViewHauptprogramm ist schon in der Klasse programm
            //instanziiert!
            //Hier könnten immer neue Views den Speicher füllen.
            //ViewHauptprogramm viewHauptprogramm = new ViewHauptprogramm();

            //Hier soll mit dem Controller aus dem Model geprüft werden, ob es einen entsprechenden 
            // Benutzer gibt...
            //Mein Vorschlag wäre es eine entsprechende Methode im 
            // Controller zu implementieren
            if (ControllerProfil.check(textBoxBenutzername.Text, textBoxPasswort.Text))
            {
                ViewHauptprogramm.Show();
                this.Hide();
            }
            else
            {
                textBoxBenutzername.Text = string.Empty;
                textBoxPasswort.Text = string.Empty;
                MessageBox.Show("No such User!");
            }



            //Die MessageBox ist imho überflüssig. Es sollte entweder ein Login erfolgen oder nicht.
            //MessageBox.Show("Sie sind nun eingeloggt.");
        }
    }
}
