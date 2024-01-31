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
    public partial class ViewLoggin : Form, IViewLoggin
    {
        private ModelLoggin modelLoggin;
        private ViewRegestrierung viewRegestrierung;
        private ViewHauptprogramm viewHauptprogramm;
        private IControllerProfile controllerProfil;

        ViewRegestrierung IViewLoggin.ViewRegestrierung { get => viewRegestrierung; set => viewRegestrierung=value; }
        ViewHauptprogramm IViewLoggin.ViewHauptprogramm { get => viewHauptprogramm; set => viewHauptprogramm=value; }
        IControllerProfile IViewLoggin.ControllerProfile { get => controllerProfil; set => controllerProfil=value; }

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

            //ViewRegestrierung.Show();

            //Der Benutzer kann direkt mit den Angaben im Loginfenster gespeichert werden.
            //ModelProfileXML benötigt noch ein speichern!
            //->IModel
            //ControllerLogin muss entsprechend angepasst werden

            controllerProfil.registrieren(textBoxBenutzername.Text, textBoxPasswort.Text);

            textBoxBenutzername.Text= string.Empty;
            textBoxPasswort.Text= string.Empty;

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
            if (controllerProfil.check(textBoxBenutzername.Text, textBoxPasswort.Text))
            {
                viewHauptprogramm.Show();
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
