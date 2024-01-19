namespace MauiApp1;

public partial class FirstPage : ContentPage
{
    INavigationService navigationService;

    public FirstPage(INavigationService navigationService)
	{
		InitializeComponent();
        this.navigationService = navigationService;
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await navigationService.GoBackAsync();
    }
}