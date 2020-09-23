using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace QuickStudyApp.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamain-quickstart"));

           
        }

        private void EnrollStudent()
        {

            try
            {
                // get the selected student

                // get the selected subject

                // call the business logic
            }
            catch (Exception e)
            {
                // show a correct error message
                
            }
            
        }

        public ICommand OpenWebCommand { get; }
    }
}