namespace MauiExample;

public partial class Inicio : ContentPage
{
    public Inicio()//Usado para executar la pagina Inicio
    {
        InitializeComponent();
    }

    /*
    Este metodo es llamado cuando el boton "voltar" es presionado
    Este boton esta definido en el archivo Inicio.xaml
    */
    private void Voltar(object sender, EventArgs e)
    {
        //Display an alert
        DisplayAlert("Alert", "Pasaras a la pagina anterior", "OK");
        /****************************************************************************************
        
        /*
        Para navegar a otra pagina (Agrega un elemento a la pila de navegacion)
        https://learn.microsoft.com/en-us/dotnet/maui/user-interface/pages/navigationpage?view=net-maui-9.0
        se deve definir un tipo de navegacion en el archivo App.xaml.cs
        */
        Navigation.PushAsync(new Menu());
        /****************************************************************************************/

    }


}