using System;

using Xamarin.Forms;

namespace Mentor.Views
{
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
        }

        public void AppointmentBtn_CLicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Area())
            {
                BarBackgroundColor = Color.FromHex("2196F3"),
                BarTextColor = Color.FromHex("FFFFFF")
            };
        }
    }
}
