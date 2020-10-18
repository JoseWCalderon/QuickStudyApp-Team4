using QuickStudyApp.ViewModels.Commands;
using QuickStudyApp.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickStudyApp.ViewModels
{
    public class ProfilePageVM
    {
        public NavigationCommand NavCommand { get; set; }

        public ProfilePageVM()
        {
            NavCommand = new NavigationCommand(this);
        }

        public async void Navigate()
        {
            //TODO navigate too

            await App.Current.MainPage.Navigation.PushAsync(new LoginPage());
        }

    }
}
