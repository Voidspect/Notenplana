using System.Runtime.CompilerServices;

namespace Notenplana23
{
    internal static class Program
    {
        //Die statischen Member müssen instanziiert werden!!!
        // -> Nach "ApplicationConfiguration.Initialize();"

        
        //Beispiel MVC Deklaration
        private static IViewLoggin viewLoggin;
        private static IControllerProfile controllerProfile;
        private static IModelProfile modelProfile;
        
        //Bitte alles folgende der Deklaration entsprechend anpassen
        // und alle Schnittstellen erstellen...
        private static ViewRegestrierung viewRegestrierung;
        private static ViewHauptprogramm viewHauptprogramm;
        private static ViewProfil viewProfil;
        private static ViewProfiBearbeiten viewProfiBearbeiten;
        private static ViewFachHj1 viewFachHj1;
        private static ViewFachBearbeitenHj1 viewFachBearbeitenHj1;
        private static ViewNoteHj1 viewNoteHj1;
        private static ViewNoteBearbeitenHj1 viewNoteBearbeitenHj1;
        private static ViewFachHj2 viewFachHj2;
        private static ViewFachBearbeitenHj2 viewFachBearbeitenHj2;
        private static ViewNoteHj2 viewNoteHj2;
        private static ViewNoteBearbeitenHj2 viewNoteBearbeitenHj2;

        private static ConrtollerLoggin controllerLoggin;
        private static ControllerRegestrierung controllerRegestrierung;
        private static ControllerHauptprogramm controllerHauptprogramm;
        private static ConrollerProfilBearbeiten controllerProfiBearbeiten;
        private static ControllerFachHj1 controllerFachHj1;
        private static ControllerFachBearbeitenHj1 controllerFachBearbeitenHj1;
        private static ControllerNoteHj1 controllerNoteHj1;
        private static ControlleNoteBearbeitenHj1 controllerNoteBearbeitenHj1;
        private static ControllerFachHj2 controllerFachHj2;
        private static ControllerFachBearbeitenHj2 controllerFachBearbeitenHj2;
        private static ControllerNoteHj2 controllerNoteHj2;
        private static ControllerNoteBearbeitenHj2 controllerNoteBearbeitenHj2;

        private static ModelLoggin modelLoggin;
        private static ModelRegestrierung modelRegestrierung;
        private static ModelHauptprogramm modelHauptprogramm;
        private static ModelProfilBearbeiten modelProfiBearbeiten;
        private static ModelFachHj1 modelFachHj1;
        private static ModelFachBearbeitenHj1 modelFachBearbeitenHj1;
        private static ModelNoteHj1 modelNoteHj1;
        private static ModelNoteBearbeitenHj1 modelNoteBearbeitenHj1;
        private static ModelFachHj2 modelFachHj2;
        private static ModelFachBearbeitenHj2 modelFachBearbeitenHj2;
        private static ModelNoteHj2 modelNoteHj2;
        private static ModelNoteBearbeitenHj2 modelNoteBearbeitenHj2;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            
            //Warum stehen die folgenden zwei Kommentarzeilen hier?
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //Am einfachsten ist es bei den vielen Models, Views und Controllern
            // alles in Methoden auszugliedern.
            // Ich habe mal den Anfang gemacht. Den Rest könnt ihr im Team vervollständigen ;-)
            modelsInstanziieren();
            viewsInstanziieren();
            controllerInstanziieren();

            modelsZuweisen();
            viewsZuweisen();
            controllerZuweisen();

            //View Login sollte es schon geben!
            //Application.Run(new ViewLoggin());
            Application.Run((Form)viewLoggin);
        }
        private static void modelsInstanziieren() 
        {
            modelProfile=new ModelProfileXML();
            //ggf. übrige Models ergänzen
        }
        private static void viewsInstanziieren()
        {
            viewLoggin = new ViewLoggin();
            viewRegestrierung = new ViewRegestrierung();
            viewHauptprogramm = new ViewHauptprogramm();
            viewProfil=new ViewProfil();
            viewProfiBearbeiten=new ViewProfiBearbeiten();
            viewFachHj1=new ViewFachHj1();
            viewFachBearbeitenHj1=new ViewFachBearbeitenHj1();
            viewNoteHj1=new ViewNoteHj1();
            viewNoteBearbeitenHj1=new ViewNoteBearbeitenHj1();
            viewFachHj2=new ViewFachHj2();
            viewFachBearbeitenHj2=new ViewFachBearbeitenHj2();
            viewNoteHj2=new ViewNoteHj2();
            viewNoteBearbeitenHj2=new ViewNoteBearbeitenHj2();
            //ggf. ergänzen
        }

        private static void controllerInstanziieren() 
        {
            controllerProfile = new ControllerProfile();
            //ggf. ergänzen
        }

        private static void modelsZuweisen() 
        {
            controllerProfile.ModelProfile = modelProfile;
            //ggf. ergänzen
        }
        private static void viewsZuweisen() 
        {
            viewLoggin.ViewRegestrierung = viewRegestrierung;
            viewLoggin.ViewHauptprogramm = viewHauptprogramm;
            //ggf. ergänzen
        }
        private static void controllerZuweisen() 
        {
            viewLoggin.ControllerProfile = controllerProfile;
            //ggf. ergänzen
        }
    }
}