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
    public partial class ReportABugPage : ContentPage
    {
        public ReportABugPage()
        {
            InitializeComponent();
        }

        async void SubmitButton(object sender, EventArgs e)
        {
            await DisplayAlert("Thank you", "We will further investigate the bug", "Close");
            await Shell.Current.GoToAsync("TypeOfQuestionPage");
        }
    }
}