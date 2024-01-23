using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notenplana23
{
    internal class ModelProfileXML : IModelProfile
    {
        void IModelProfile.ausgeben(Profil profil)
        {
            throw new NotImplementedException();
        }

        bool IModelProfile.check(string Benutzername, string Passwort)
        {
            //Nur zum Testen
            if(Benutzername == "Horst" && Passwort=="12345")
            {
                return true;
            }
            else
                return false;
        }
    }
}
