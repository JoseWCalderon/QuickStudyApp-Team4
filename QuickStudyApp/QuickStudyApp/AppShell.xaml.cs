using System;
using System.Collections.Generic;
using QuickStudyApp.ViewModels;
using QuickStudyApp.Views;
using Xamarin.Forms;

namespace QuickStudyApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
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
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
