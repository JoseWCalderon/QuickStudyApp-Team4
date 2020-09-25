using QuickStudyApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuickStudyApp.Views

{
    [QueryProperty("Details", "details")]
    public partial class FAQDetailsPage : ContentPage
    {

        public string Details 
        {
            set
            {
                //BindingContext = FAQData.Questions.FirstOrDefault(m => m.Question == Uri.UnescapeDataString(value));
            }
        }


        public FAQDetailsPage()
        {
            InitializeComponent();
        }
    }
}