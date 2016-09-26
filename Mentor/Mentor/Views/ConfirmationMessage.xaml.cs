using System;
using Xamarin.Forms;

namespace Mentor.Views
{
    public partial class ConfirmationMessage : ContentPage
    {
        public ConfirmationMessage()
        {
            InitializeComponent();
        }

        private void HomeBtn_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Home())
            {
                BarBackgroundColor = Color.FromHex("2196F3"),
                BarTextColor = Color.FromHex("FFFFFF")
            };
        }
    }
}
