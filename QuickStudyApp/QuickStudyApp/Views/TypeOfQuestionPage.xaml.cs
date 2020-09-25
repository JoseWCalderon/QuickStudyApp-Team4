using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuickStudyApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TypeOfQuestionPage : ContentPage
    {
        public TypeOfQuestionPage()
        {
            InitializeComponent();
        }

        async void AskAQuestionButton(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("AskAQuestionPage");
        }

        async void LeaveFeedbackButton(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("LeaveFeedbackPage");
        }

        async void ReportABugButton(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("ReportABugPage");
        }
    }
}