using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Notenplana23
{
    internal class ModelProfileXML : IModelProfile
    {
        private XDocument doc;
        public ModelProfileXML()
        {
            doc = XDocument.Load("Profile.xml");
        }
        void IModelProfile.ausgeben(Profil profil)
        {
            throw new NotImplementedException();
        }

        bool IModelProfile.check(string Benutzername, string Passwort)
        {
            //Nur zum Testen

            //Im XML-File nach Name und PWD suchen!

            if(Benutzername == "Horst" && Passwort=="12345")
            {
                return true;
            }
            else
                return false;
        }

    }
}
