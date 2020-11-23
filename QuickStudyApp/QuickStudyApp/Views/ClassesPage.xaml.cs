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
    public partial class ClassesPage : ContentPage
    {
        public ClassesPage()
        {
            InitializeComponent();
        }
        
        async void MyGroupsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyGroups());
        }

        async void ToolsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ToolsMainPage());
        }

        async void HelpClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HelpSessions());
        }

    }
}