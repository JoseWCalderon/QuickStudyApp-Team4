using System;
using System.Collections.Generic;
using QuickStudyApp.ViewModels;
using QuickStudyApp.Views;
using Xamarin.Forms;

namespace QuickStudyApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        Dictionary<string, Type> routes = new Dictionary<string, Type>();
        public Dictionary<string, Type> Routes { get { return routes; } }
        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
        }

        void RegisterRoutes()
        {
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(FAQPage), typeof(FAQPage));
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Routing.RegisterRoute(nameof(FAQDetailsPage), typeof(FAQDetailsPage));
            Routing.RegisterRoute(nameof(TypeOfQuestionPage), typeof(TypeOfQuestionPage));
            Routing.RegisterRoute(nameof(AskAQuestionPage), typeof(AskAQuestionPage));
            Routing.RegisterRoute(nameof(ReportABugPage), typeof(ReportABugPage));
            Routing.RegisterRoute(nameof(LeaveFeedbackPage), typeof(LeaveFeedbackPage));
            Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
            Routing.RegisterRoute(nameof(ProfilePage), typeof(ProfilePage));
            Routing.RegisterRoute(nameof(ThirdPartyPage), typeof(ThirdPartyPage));
          //  Routing.RegisterRoute(nameof(CalendarPage), typeof(CalendarPage));
            Routing.RegisterRoute(nameof(ChannelPage), typeof(ChannelPage));
            Routing.RegisterRoute(nameof(ContactPage), typeof(ContactPage));
            Routing.RegisterRoute(nameof(FilePage), typeof(FilePage));
            Routing.RegisterRoute(nameof(ChannelDetailPage), typeof(ChannelDetailPage));
            Routing.RegisterRoute(nameof(Schedule), typeof(Schedule));
            Routing.RegisterRoute(nameof(AssignmentDue), typeof(AssignmentDue));
            Routing.RegisterRoute(nameof(NewAssignmentDueDate), typeof(NewAssignmentDueDate));
            Routing.RegisterRoute(nameof(NotesPage), typeof(NotesPage));
            //Routing.RegisterRoute(nameof(NewCalendar), typeof(NewCalendar));



            foreach (var item in routes)
            {
                Routing.RegisterRoute(item.Key, item.Value);
            }
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }

        //side bar flyout menu navigation link method navigation
        private async void MyProfileItemClicked(object sender, EventArgs e)
        {
           // await Navigation.PushAsync("ProfilePage");
            await Shell.Current.GoToAsync("ProfilePage");
        }
    }
}
