using Mentor.Views;
using Xamarin.Forms;

namespace Mentor
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            var content = new Home();
            MainPage = new NavigationPage(content)
            {
                BarBackgroundColor = Color.FromHex("2196F3"),
                BarTextColor = Color.FromHex("FFFFFF")
            };
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
