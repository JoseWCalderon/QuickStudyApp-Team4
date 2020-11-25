using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
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
            //download link sample here, a simple image file can be placed in the uri file
            Device.OpenUri(new Uri("https://filebin.net/archive/0od6xfwruhx41y2g/zip?t=rfl84i9v"));
        }
    }
}
