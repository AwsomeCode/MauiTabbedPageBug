namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        INavigationService navigationService;
        public MainPage(INavigationService navigationService)
        {
            InitializeComponent();
            this.navigationService = navigationService;
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            await navigationService.NavigateAsync("FirstPage");
            //count++;

            //if (count == 1)
            //    CounterBtn.Text = $"Clicked {count} time";
            //else
            //    CounterBtn.Text = $"Clicked {count} times";

            //SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
