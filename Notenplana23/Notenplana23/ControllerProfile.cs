using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notenplana23
{
    internal class ControllerProfile
    {
        private IModelProfile modelProfile;
        private ViewProfil viewProfil;

        
        protected ViewProfil ViewProfil {get => viewProfil; }
        public IModelProfile ModelProfile { get => modelProfile; set => modelProfile = value; }

        internal bool check(string Benutzername, string Passwort)
        {
            if(modelProfile.check(Benutzername,Passwort))
                return true;
            else
                return false;
        }
    }
}
