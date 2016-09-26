using System;
using Xamarin.Forms;

namespace Mentor.Views
{
    public partial class DateTimeSelection : ContentPage
    {
        private string studyArea;
        private string mentor;
        public DateTimeSelection(string area, string mentor)
        {
            InitializeComponent();
            this.studyArea = area;
            this.mentor = mentor;
            BookDate.MinimumDate = new DateTime(2000, 1, 1);
            BookDate.MaximumDate = new DateTime(2050, 12, 31);
        }


        private void AppointmentBtn_Clicked(object sender, EventArgs e)
        {
            string bookDate = BookDate.Date.ToString("d");
            string bookTime = PreferredTime.Time.ToString();
            Application.Current.MainPage = new NavigationPage(new BookingConfirmation(studyArea, mentor, bookDate, bookTime))
            {
                BarBackgroundColor = Color.FromHex("2196F3"),
                BarTextColor = Color.FromHex("FFFFFF")
            };
        }
    }
}
