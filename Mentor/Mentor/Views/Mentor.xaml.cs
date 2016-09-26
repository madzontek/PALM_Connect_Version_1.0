using System;

using Xamarin.Forms;

namespace Mentor.Views
{
    public partial class Mentor : ContentPage
    {
        private string studyArea;
        public Mentor(string area)
        {
            InitializeComponent();
            studyArea = area;
            StudyArea.Text = area;
        }

        public void Mentor1Btn_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new DateTimeSelection(studyArea, "Mentor 1"))
            {
                BarBackgroundColor = Color.FromHex("2196F3"),
                BarTextColor = Color.FromHex("FFFFFF")
            };
        }

        public void Mentor2Btn_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new DateTimeSelection(studyArea, "Mentor 2"))
            {
                BarBackgroundColor = Color.FromHex("2196F3"),
                BarTextColor = Color.FromHex("FFFFFF")
            };
        }

        public void Mentor3Btn_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new DateTimeSelection(studyArea, "Mentor 3"))
            {
                BarBackgroundColor = Color.FromHex("2196F3"),
                BarTextColor = Color.FromHex("FFFFFF")
            };
        }
        public void Mentor4Btn_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new DateTimeSelection(studyArea, "Mentor 4"))
            {
                BarBackgroundColor = Color.FromHex("2196F3"),
                BarTextColor = Color.FromHex("FFFFFF")
            };
        }
        public void Mentor5Btn_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new DateTimeSelection(studyArea, "Mentor 5"))
            {
                BarBackgroundColor = Color.FromHex("2196F3"),
                BarTextColor = Color.FromHex("FFFFFF")
            };
        }
        public void Mentor6Btn_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new DateTimeSelection(studyArea, "Mentor 6"))
            {
                BarBackgroundColor = Color.FromHex("2196F3"),
                BarTextColor = Color.FromHex("FFFFFF")
            };
        }
        public void Mentor7Btn_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new DateTimeSelection(studyArea, "Mentor 7"))
            {
                BarBackgroundColor = Color.FromHex("2196F3"),
                BarTextColor = Color.FromHex("FFFFFF")
            };
        }
        public void Mentor8Btn_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new DateTimeSelection(studyArea, "Mentor 8"))
            {
                BarBackgroundColor = Color.FromHex("2196F3"),
                BarTextColor = Color.FromHex("FFFFFF")
            };
        }
        public void Mentor9Btn_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new DateTimeSelection(studyArea, "Mentor 9"))
            {
                BarBackgroundColor = Color.FromHex("2196F3"),
                BarTextColor = Color.FromHex("FFFFFF")
            };
        }
        public void Mentor10Btn_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new DateTimeSelection(studyArea, "Mentor 10"))
            {
                BarBackgroundColor = Color.FromHex("2196F3"),
                BarTextColor = Color.FromHex("FFFFFF")
            };
        }
    }
}
