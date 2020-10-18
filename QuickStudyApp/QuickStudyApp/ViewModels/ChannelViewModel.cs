using System;
using System.Windows.Input;
using MvvmHelpers.Commands;
using Xamarin.Forms;


namespace QuickStudyApp.ViewModels
{
    public class ChannelViewModel : BaseViewModel
    {
        public ICommand OnClicked { get; }
        
        //public OnClicked => new Command<string>()) =>
        //{
           
        //});

        [Obsolete]
        public ICommand ClickCommand => new Xamarin.Forms.Command<string>((url) =>
        {
            Device.OpenUri(new System.Uri(url));
        });

        [Obsolete]
        public ICommand ClickContacts => new Xamarin.Forms.Command<string>((url) =>
        {
            Device.OpenUri(new System.Uri(url));
        });

        [Obsolete]
        public ICommand ClickFiles => new Xamarin.Forms.Command<string>((url) =>
        {
            Device.OpenUri(new System.Uri(url));
        });
    }
}
