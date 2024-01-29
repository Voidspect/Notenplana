namespace Notenplana23
{
    internal interface IControllerProfile
    {
        ViewProfil ViewProfil { get; set; }
        IModelProfile ModelProfile { get; set; }

        bool check(string Benutzername, string Passwort);
        void registrieren(string Benutzername, string Passwort);
    }
}