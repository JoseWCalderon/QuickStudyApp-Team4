using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace QuickStudyApp.ViewModels.Commands
{
    public class DownloadCommand : ICommand
    {
        public DownloadVM DownloadViewModel { get; set; }

        public DownloadCommand(DownloadVM downloadVM)
        {
            DownloadViewModel = downloadVM;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            //var browser = new WebView();
            //browser.Source = "https://echo360.org.au/courses#userIdentifier=3a6845f0-a554-4287-9372-e23e4e2b1e42_3936d02b-2b21-400d-82a5-33ecb8536eb8&viewType=grid&field=termStart&order=desc";
            //ContentPage = browser;




            //download link sample here, a simple image file can be placed in the uri file
            Launcher.OpenAsync(new Uri("https://filebin.net/archive/0od6xfwruhx41y2g/zip?t=rfl84i9v"));
        }
    }
}
