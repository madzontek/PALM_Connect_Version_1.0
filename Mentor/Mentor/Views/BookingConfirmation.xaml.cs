using System;
using Xamarin.Forms;

namespace Mentor.Views
{
    public partial class BookingConfirmation : ContentPage
    {
        private string studyArea;
        private string userMentor;
        private string meetingDate;
        private string meetingTime;
        public BookingConfirmation(string area, string mentor, string date, string time)
        {
            InitializeComponent();
            studyArea = area;
            userMentor = mentor;
            meetingDate = date;
            meetingTime = time;
            Area.Text = area;
            Mentor.Text = mentor;
            MeetingDate.Text = date;
            MeetingTime.Text = time;
        }

        private void DeactiveBtn_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Home())
            {
                BarBackgroundColor = Color.FromHex("2196F3"),
                BarTextColor = Color.FromHex("FFFFFF")
            };
        }

        private void ConfirmBtn_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new PersonalDetails(studyArea, userMentor, meetingDate, meetingTime))
            {
                BarBackgroundColor = Color.FromHex("2196F3"),
                BarTextColor = Color.FromHex("FFFFFF")
            };
        }
    }
}
