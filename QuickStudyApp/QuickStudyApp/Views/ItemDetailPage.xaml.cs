using System.ComponentModel;
using Xamarin.Forms;
using QuickStudyApp.ViewModels;

namespace QuickStudyApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}