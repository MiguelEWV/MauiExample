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

    }

    private void stepperControl_ValueChanged(object sender, ValueChangedEventArgs e)
    {

    }

    private void SwipeItem_Invoked(object sender, EventArgs e)
    {

    }
}