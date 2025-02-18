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

    private void ExGrid(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new ExGrid());
    }

    private void ExAbsoluteLayout(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new ExAbsoluteLayout());
    }
    

    private void ExFlexLayout(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new ExFlexLayout());
    }
    




}