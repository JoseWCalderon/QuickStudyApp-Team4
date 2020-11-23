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
    public partial class AskAQuestionPage : ContentPage
    {
        public AskAQuestionPage()
        {
            InitializeComponent();
        }

        private async void SubmitButton(object sender, EventArgs e)
        {
            await DisplayAlert("Success", "Your message has been sent!", "Close");
            await Application.Current.MainPage.Navigation.PopAsync(); //Remove the page currently on top.
        }
    }
}