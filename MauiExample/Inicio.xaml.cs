namespace MauiExample;

public partial class Inicio : ContentPage
{
    public Inicio()//Usado para executar la pagina Inicio
    {
        InitializeComponent();
    }

    /*
    Este metodo es llamado cuando el boton "Entrar" es presionado
    Este boton esta definido en el archivo Inicio.xaml
    Esta linea de codigo sin el "async" permite que el usuario navegue a la pagina ExContentPage sin esperar la respuesta del usuario
    private async void Entrar(object sender, EventArgs e)
    */
    private async void Entrar(object sender, EventArgs e)
    {
        //Display an simple alert
        //DisplayAlert("Alert", "Pasaras a la ExContentPage", "OK");
        /****************************************************************************************
        
        /*
        Para aguardar o usuario clicar en ok para la sigiente funcion
        https://learn.microsoft.com/en-us/dotnet/maui/user-interface/pop-ups?view=net-maui-9.0
        */
        await DisplayAlert("Question?", "Deseas passar para la pagina \n ExContentPage", "Ok");
        
        /*
        Para navegar a otra pagina (Agrega un elemento a la pila de navegacion)
        https://learn.microsoft.com/en-us/dotnet/maui/user-interface/pages/navigationpage?view=net-maui-9.0
        se deve definir un tipo de navegacion en el archivo App.xaml.cs
        */
        //Navigation.PushAsync(new ExContentPage()); Usado caso nao se espere la resposta do usuario con el await y el async void.
        await Navigation.PushModalAsync(new ExContentPage());
        /****************************************************************************************/

    }


}