namespace MauiExample;

public partial class ExComandControl : ContentPage
{
	public ExComandControl()
	{
		InitializeComponent();
	}

    private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
		DisplayAlert("Alert", "CheckBox CheckedChanged", "OK");
    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Alert", "ImageButton Clicked", "OK");
    }

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        DisplayAlert("Alert", "RadioButton CheckedChanged", "OK");
    }

    private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
    {

    }

    private void TimePicker_TimeSelected(object sender, TimeChangedEventArgs e)
    {

    }

    private void searchControl_SearchButtonPressed(object sender, EventArgs e)
    {

    }

    private void sliderControl_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        //Indico que voi a usar el control lblSliderValue, que es un label para mostrar el valor del slider en tiempo real.
        //.Text es el texto que se muestra en el label. (Uso "." para llamar una propiedad, no caso a propiedad "Text")
        //e.NewValue es el valor actual del slider.
        //e. representa el evento que se esta ejecutando. que es el evento ValueChangedEventArgs. que esta en el private void sliderControl_ValueChanged(object sender, ValueChangedEventArgs e)
        //ToString() convierte el valor a string para poder mostrarlo en el label.

        lblSliderValue.Text = e.NewValue.ToString();

    }

    private void stepperControl_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        if (stepperControl != null) //Verifico si Esteper no es null para executar este codigo, llamando por el nombre x:name stepperControl
        { 
            lblSliderValue.Text = stepperControl.Value.ToString();
        }
    }

    private void SwipeItem_Invoked(object sender, EventArgs e)
    {

    }
}