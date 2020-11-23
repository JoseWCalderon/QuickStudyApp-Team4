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
    public partial class RecordingsPageWeb : ContentPage
    {
        public RecordingsPageWeb()
        {
            var browser = new WebView();
            browser.Source = "https://echo360.org.au/courses#userIdentifier=3a6845f0-a554-4287-9372-e23e4e2b1e42_3936d02b-2b21-400d-82a5-33ecb8536eb8&viewType=grid&field=termStart&order=desc";
            Content = browser;
        }
    }
}