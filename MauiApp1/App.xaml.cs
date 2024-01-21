

namespace MauiApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainTabbedPage());
        }
    }

    public class MainTabbedPage : TabbedPage
    {
        public MainTabbedPage()
        {
            this.Children.Add(new ContentPage
            {
                Title = "Page 1",
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label { Text = "Page 1" },
                        new Button { Text = "Go to ProductTabbedPage", Command = new Command(Clicked) }
                    }
                }
            }); 
            this.Children.Add(new ContentPage
            {
                Title = "Page 2",
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label { Text = "Page 2" }
                    }
                }
            });
        }

        private async void Clicked(object obj)
        {
            await Navigation.PushAsync(new ProductTabbedPage());
        }
    }

    public class ProductTabbedPage : TabbedPage
    {
        public ProductTabbedPage()
        {
            this.Children.Add(new ContentPage
            {
                Title = "Product 1",
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label { Text = "Page 1" },
                    }
                }
            });
            this.Children.Add(new ContentPage
            {
                Title = "Product 2",
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label { Text = "Page 2" }
                    }
                }
            });
        }
    }
}