using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Forms320
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            
            //var page  = new Sample01Page();
            //var page = new Sample02Page();
            //var page = new Sample03Page();
            //var page = new Sample04Page();
            //var page = new Sample05Page();
            var page = new Sample06Page();

            MainPage = new NavigationPage(page);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
