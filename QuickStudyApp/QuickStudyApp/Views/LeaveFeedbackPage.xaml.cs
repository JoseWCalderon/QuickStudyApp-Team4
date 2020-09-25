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
    public partial class LeaveFeedbackPage : ContentPage
    {
        public LeaveFeedbackPage()
        {
            InitializeComponent();
        }

        async void SubmitButton(object sender, EventArgs e)
        {
            await DisplayAlert("Success", "Thank you for your feedback", "Close");
            await Shell.Current.GoToAsync("TypeOfQuestionPage");
        }
    }
}