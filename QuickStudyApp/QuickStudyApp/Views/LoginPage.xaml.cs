using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickStudyApp.Models;
using QuickStudyApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuickStudyApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        
        
        public LoginPage()
        {
            InitializeComponent();
            
           // this.BindingContext = new HomePage();
        }

        private async void Login_Clicked(object sender, EventArgs e)
        {
            //var HomePageView = new HomePage();
            //this.Navigate(typeof(HomePage), null);
            //App.Current.MainPage.Navigation.PushAsync(new HomePage());
            //await Shell.Current.GoToAsync("HomePage");

            // await Navigation.PushAsync(new HomePage());

            // store here true or false if the text entry is empty
            bool isStudentIDEmpty = string.IsNullOrEmpty(studentIDEntry.Text);

            //check condition here and do this
            if(isStudentIDEmpty == true)
            {
                await DisplayAlert("Sign In Details Incorrect", "Please type in your Student ID", "Close");
            }
            else
            {
              //  await App.Current.MainPage.Navigation.PushAsync(new AppShell());
                await App.Current.MainPage.Navigation.PopToRootAsync();
            }
            

            
        }
    }
}