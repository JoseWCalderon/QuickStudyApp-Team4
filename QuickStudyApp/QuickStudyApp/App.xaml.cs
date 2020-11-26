using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using QuickStudyApp.Services;
using QuickStudyApp.Views;

namespace QuickStudyApp
{
    public partial class App : Application
    {
        public static string DatabaseLocation = string.Empty;
        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();

            //try to load the account from a secure storage xamarin.essentials


            //load our main page here through MainPage
           // MainPage = new NavigationPage(new LoginPage());
            MainPage = new AppShell();
        }

        public App(string databaseLocation)
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();

            MainPage = new AppShell();

            DatabaseLocation = databaseLocation;
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
