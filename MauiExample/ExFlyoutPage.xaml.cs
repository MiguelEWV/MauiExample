namespace MauiExample;

public partial class ExFlyoutPage : FlyoutPage
{
	public ExFlyoutPage()
	{
		InitializeComponent();
	}

    private void ExStackLayout(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new ExStackLayout());
    }

    private void ExTabbedPage(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new ExTabbedPage());
    }
}