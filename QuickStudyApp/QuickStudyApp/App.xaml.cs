using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using QuickStudyApp.Services;
using QuickStudyApp.Views;

namespace QuickStudyApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();

            //try to load the account from a secure storage xamarin.essentials

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
