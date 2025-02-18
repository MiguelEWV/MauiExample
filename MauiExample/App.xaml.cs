namespace MauiExample
{
    public partial class App : Application
    {
        [Obsolete] //Usado para funcionar el NavigationPage
        public App()
        {
            InitializeComponent();//Necessario para iniciar la aplicacion


            /*
            Inicia en Menu y Permite navegar a Inicio, caso sea necesario,
            atraves del boton, "Entrar" en Menu.xaml
            Se Coloca anteriormente el [Obsolete] para evitar errores de compilacion
            Com este codigo simples Advertencia "se crea una barra superior de navegacion"
            Funciona con el codigo "Navigation.PushAsync(new Inicio());" que esta en Menu.xaml.cs
            en le boton de funcion
            */
            //MainPage = new NavigationPage(new Menu());
            /**********************************************

            /*
            Codigo com barra de navegacao personalizada.
            
            var navigationPage = new NavigationPage(new Menu());
            navigationPage.BarBackgroundColor = Color.FromHex("#3498db");
            navigationPage.BarTextColor = Color.FromHex("#3498db");
            MainPage = navigationPage;
            */
            /**************************************************************/

            /*
            Codigo para mostrar Menu lateral no inivcio de la aplicacion.
            */
            MainPage = new ExFlexLayout();
            /**************************************************************/

        }

        /*
           protected override Window CreateWindow(IActivationState? activationState)
           {

               //return new Window(new Inicio()); //Descomentar esta linea si se quiere iniciar en la pagina Inicio
               //return new Window(new MainPage()); Descomentar esta linea si se quiere iniciar en la pagina MainPage
               //El siguiente codigo inicia en inicio y pasa a MainPage caso sea necesario atraves del boton
               //return new Window(new Menu());

               //Caso dese pasar informacion de una pagina a otra se puede hacer de la siguiente manera
               //https://learn.microsoft.com/en-us/dotnet/maui/user-interface/pages/navigationpage?view=net-maui-9.0#pass-data-through-a-page-constructor
               //return new Window(new Inicio(new MainPage("Informacion a pasar")));

               /*
                   Contact contact = new Contact
                   {
                       Name = "Jane Doe",
                       Age = 30,
                       Occupation = "Developer",
                       Country = "USA"
                   };
                   ...
                   await Navigation.PushModalAsync(new DetailsPage(contact));
        
           }
        */

        //Para crear saltos de linea dentro de textos en archivos xaml se puede usar "&#10;"
    }
}