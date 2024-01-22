using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notenplana23
{
    internal class ControllerProfil
    {
        private ModelProfil modelProfil;
        private ViewProfil viewProfil;

        protected ModelProfil ModelProfil {get => ModelProfil; }
        protected ViewProfil ViewProfil {get => ViewProfil; }

        internal bool check(string Benutzername, string Passwort)
        {
            //Nur zum Testen...
            if(Benutzername=="Horst"&&Passwort=="12345")
                return true;
            else
                return false;
        }
    }
}
