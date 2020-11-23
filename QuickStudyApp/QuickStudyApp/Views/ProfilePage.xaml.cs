using QuickStudyApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuickStudyApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {

        ProfilePageVM viewModel;
        public ProfilePage()
        {
            InitializeComponent();
            viewModel = new ProfilePageVM();
            BindingContext = viewModel;
        }
    }
}