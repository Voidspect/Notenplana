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
            try
            {
                doc = XDocument.Load("Profile.xml");
            }
            
            catch
            {
                XDocument doc = new XDocument(
                    new XElement("profile",
                        new XElement("profil",
                        new XAttribute("name", "Horst Fleißig"),
                        new XAttribute("passwort", "12345"),
                            new XElement("fach",
                                new XAttribute("name", "Deutsch"),
                                new XElement("note",
                                    new XAttribute("halbjahr", "1"),
                                    new XAttribute("art", "solei"),
                                    "1")))));

                doc.Save("Profile.xml");
                MessageBox.Show(doc.ToString());
            }
        }
        void IModelProfile.ausgeben(Profil profil)
        {
            throw new NotImplementedException();
        }

        bool IModelProfile.check(string Benutzername, string Passwort)
        {
            //Im XML-File nach Name und PWD suchen.
            //IEnumerable<XElement> result =
            //    doc.Descendants("profil")
            //    .Where(element
            //    => element.Attribute("name").Value == Benutzername
            //    && element.Attribute("passwort").Value == Passwort);

            //if (result.Count()>0)
            //{
            //    return true;
            //}
            //else
                return false;
        }

    }
}
