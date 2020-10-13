using QuickStudyApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace QuickStudyApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        
        public Command LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        private async void OnLoginClicked(object obj)
        {

            //// Prefixing with `//` switfferent navigation stack instead of pushing to the active one
            await App.Current.MainPage.Navigation.PopToRootAsync();



            //await Application.Current.MainPage = new AppShell();
        }
    }
}
