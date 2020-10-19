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
    public partial class ToolsMainPage : ContentPage
    {
        public ToolsMainPage()
        {
            InitializeComponent();
        }

        private async void RecordingsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RecordingsPageWeb());
        }

        private async void MyGradesClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyGrades());
        }
    }
}