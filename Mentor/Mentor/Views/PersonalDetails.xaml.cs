using System;
using Xamarin.Forms;

namespace Mentor.Views
{
    public partial class PersonalDetails : ContentPage
    {
        private string studyArea;
        private string userMentor;
        private string meetingDate;
        private string meetingTime;
        public PersonalDetails(string area, string mentor, string date, string time)
        {
            InitializeComponent();
            studyArea = area;
            userMentor = mentor;
            meetingDate = date;
            meetingTime = time;
        }

        private void SubmitBtn_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Name.Text))
            {
                DisplayAlert("Notification", "Name field cannot be empty", "OK");
            }
            else if (string.IsNullOrEmpty(ID.Text))
            {
                DisplayAlert("Notification", "ID field cannot be empty", "OK");
            }
            else if (string.IsNullOrEmpty(Email.Text))
            {
                DisplayAlert("Notification", "Email field cannot be empty", "OK");
            }
            else if (string.IsNullOrEmpty(Phone.Text))
            {
                DisplayAlert("Notification", "Phone field cannot be empty", "OK");
            }
            else
            {
                string userName = Name.Text;
                string userId = ID.Text;
                string userEmail = Email.Text;
                string userPhone = Phone.Text;

                string to = "madzontek@gmail.com";
                string subject = "New Booking Request";
                string body = $"Name: {userName} \n ID: {userId} \n Email: {userEmail} \n Phone: {userPhone} \n Study Area: {studyArea} \n Mentor: {userMentor} \n Date: {meetingDate} \n Time: {meetingTime}";
                string mail = $"mailto:{to}?subject={subject}&body={body}";
                Device.OpenUri(new Uri(mail));

                Application.Current.MainPage = new NavigationPage(new ConfirmationMessage())
                {
                    BarBackgroundColor = Color.FromHex("2196F3"),
                    BarTextColor = Color.FromHex("FFFFFF")
                };
            }
        }
    }
}
