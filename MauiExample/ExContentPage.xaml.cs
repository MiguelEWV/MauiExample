
namespace MauiExample;

public partial class ExContentPage : ContentPage
{
    public ExContentPage()
    {
        InitializeComponent();
    }
    
    /*
    public Menu(Inicio inicio)
    {
        InitializeComponent();
    }
    */

    // Este metodo es llamado cuando el boton "Entrar" es presionado
    //Este boton esta definido en el archivo Menu.xaml
    private void ExFlyoutPage(object sender, EventArgs e)
    {
        //Display an alert
        DisplayAlert("Alert", "Pasaras a la proxima pagina", "OK");

        //Para navegar a otra pagina (Agrega un elemento a la pila de navegacion)
        //https://learn.microsoft.com/en-us/dotnet/maui/user-interface/pages/navigationpage?view=net-maui-9.0
        //se deve definir un tipo de navegacion en el archivo App.xaml.cs
        //Navigation.PushAsync(new ExFlyoutPage());
        Navigation.PushModalAsync(new ExFlyoutPage());


    }


}