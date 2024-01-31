namespace Notenplana23
{
    internal interface IViewLoggin
    {
        ViewRegestrierung ViewRegestrierung { get; set; }
        ViewHauptprogramm ViewHauptprogramm { get; set; }
        IControllerProfile ControllerProfile { get; set; }
    }
}