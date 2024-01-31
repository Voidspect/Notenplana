using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notenplana23
{
    internal interface IModelProfile
    {
        void ausgeben(Profil profil);
        bool check(string Benutzername, string Passwort);

        void speichern(string Benutzername, string Passwort);
    }
}
