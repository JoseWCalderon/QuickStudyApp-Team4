using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace QuickStudyApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalendarPage : ContentPage
    {
        public CalendarPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //returns here a true or false boolean result from the canopenasync

            await Launcher.TryOpenAsync("https://play.google.com/store/apps/");

            //if (await Launcher.CanOpenAsync("calculator://"))
            //{
            //    await Launcher.OpenAsync("chrome://");
            //}
        }
    }
}