using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notenplana23
{
    internal class ControllerProfile:IControllerProfile
    {
        private IModelProfile modelProfile;
        private ViewProfil viewProfil;

        
        ViewProfil IControllerProfile.ViewProfil { get => viewProfil; set => viewProfil = value; }
        IModelProfile IControllerProfile.ModelProfile { get => modelProfile; set => modelProfile = value; }

        bool IControllerProfile.check(string Benutzername, string Passwort)
        {
            if(modelProfile.check(Benutzername,Passwort))
                return true;
            else
                return false;
        }

        void IControllerProfile.registrieren(string Benutzername, string Passwort) 
        {
            modelProfile.speichern(Benutzername, Passwort);
        }
    }
}
