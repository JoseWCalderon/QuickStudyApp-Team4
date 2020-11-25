using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace QuickStudyApp.ViewModels.Commands
{
    public class NavigationCommand : ICommand

    {

        public ProfilePageVM ProfilePageViewModel { get; set; }

        public NavigationCommand(ProfilePageVM profilePageVM)
        {
            ProfilePageViewModel = profilePageVM;
        }



        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ProfilePageViewModel.Navigate();
        }
    }
}
