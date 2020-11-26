using QuickStudyApp.ViewModels;
using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace QuickStudyApp.Views
{
    public partial class FilePage : ContentPage
    {

        DownloadVM viewModel;
        public FilePage()
        {
            InitializeComponent();

            viewModel = new DownloadVM();
            BindingContext = viewModel;
        }

        //this has been replacted by an ICommand
        private void DownloadFileClicked(object sender, EventArgs e)
        {
            //download link sample here, a simple image file can be placed in the uri file
           // Launcher.OpenAsync(new Uri("https://filebin.net/archive/0od6xfwruhx41y2g/zip?t=rfl84i9v"));
            
        }
    }
}
