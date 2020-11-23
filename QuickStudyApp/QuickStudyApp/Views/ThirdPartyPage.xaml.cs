using QuickStudyApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuickStudyApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ThirdPartyPage : ContentPage
    {
        public IList<ThirdParty> ThirdParties { get; private set; }
        public ThirdPartyPage()
        {
            InitializeComponent();

            ThirdParties = new List<ThirdParty>();
            ThirdParties.Add(new ThirdParty
            {
                Name = "Application Link (Google Sample)",
                LinkUrl = "http://www.google.com.au"
            });

            //set this as the binding to the front to have access to this thought {Binding "nameofvariable"}
            BindingContext = this;
        }

        private void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //ThirdParty selectedItem = e.SelectedItem as ThirdParty;
            //Device.OpenUri(new System.Uri("https://play.google.com/store/apps"));

            Launcher.TryOpenAsync("http://play.google.com/store/apps/details?id=com.google.android.apps.maps");
        }

        private void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            ThirdParty TappedItem = e.Item as ThirdParty;
        }
    }
}
