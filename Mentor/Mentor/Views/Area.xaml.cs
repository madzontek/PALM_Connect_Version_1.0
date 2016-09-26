using System;

using Xamarin.Forms;

namespace Mentor.Views
{
    public partial class Area : ContentPage
    {
        public Area()
        {
            InitializeComponent();
        }

        public void Area1Btn_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Mentor("Study Area 1"))
            {
                BarBackgroundColor = Color.FromHex("2196F3"),
                BarTextColor = Color.FromHex("FFFFFF")
            };
        }

        public void Area2Btn_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Mentor("Study Area 2"))
            {
                BarBackgroundColor = Color.FromHex("2196F3"),
                BarTextColor = Color.FromHex("FFFFFF")
            };
        }

        public void Area3Btn_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Mentor("Study Area 3"))
            {
                BarBackgroundColor = Color.FromHex("2196F3"),
                BarTextColor = Color.FromHex("FFFFFF")
            };
        }

        public void Area4Btn_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Mentor("Study Area 4"))
            {
                BarBackgroundColor = Color.FromHex("2196F3"),
                BarTextColor = Color.FromHex("FFFFFF")
            };
        }
        public void Area5Btn_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Mentor("Study Area 5"))
            {
                BarBackgroundColor = Color.FromHex("2196F3"),
                BarTextColor = Color.FromHex("FFFFFF")
            };
        }
        public void Area6Btn_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Mentor("Study Area 6"))
            {
                BarBackgroundColor = Color.FromHex("2196F3"),
                BarTextColor = Color.FromHex("FFFFFF")
            };
        }
        public void Area7Btn_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Mentor("Study Area 7"))
            {
                BarBackgroundColor = Color.FromHex("2196F3"),
                BarTextColor = Color.FromHex("FFFFFF")
            };
        }
        public void Area8Btn_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Mentor("Study Area 8"))
            {
                BarBackgroundColor = Color.FromHex("2196F3"),
                BarTextColor = Color.FromHex("FFFFFF")
            };
        }
        public void Area9Btn_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Mentor("Study Area 9"))
            {
                BarBackgroundColor = Color.FromHex("2196F3"),
                BarTextColor = Color.FromHex("FFFFFF")
            };
        }
        public void Area10Btn_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Mentor("Study Area 10"))
            {
                BarBackgroundColor = Color.FromHex("2196F3"),
                BarTextColor = Color.FromHex("FFFFFF")
            };
        }
    }
}
