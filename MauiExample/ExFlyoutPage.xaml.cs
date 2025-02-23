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

    private void ExControlsPresentation(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new ExControlsPresentation());
    }

    private void ExComandControl(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new ExComandControl());
    }
    //8888888
    private void ExActivityIndicator(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new ExActivityIndicator());
    }
    private void ExCarouselView(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new ExCarouselView());
    }
    private void ExContentPage(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new ExContentPage());
    }
    




}