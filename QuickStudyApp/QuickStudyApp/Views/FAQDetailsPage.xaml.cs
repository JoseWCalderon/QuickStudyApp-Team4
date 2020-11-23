using QuickStudyApp.Data;
using QuickStudyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Markup;
using Xamarin.Forms.Markup.LeftToRight;
using Xamarin.Forms.Xaml;

namespace QuickStudyApp.Views

{
    [QueryProperty("Details", "details")]
    public partial class FAQDetailsPage : ContentPage
    {
        FAQ selectedFAQ;
        public FAQDetailsPage()
        {

        }

        public string Details 
        {
            set
            {
                //BindingContext = FAQData.Questions.FirstOrDefault(m => m.Question == Uri.UnescapeDataString(value));
            }
        }


        public FAQDetailsPage(FAQ selectedFAQ)
        {
            InitializeComponent();

            this.selectedFAQ = selectedFAQ;

            //to the front view here
            questionLabal.Text = selectedFAQ.Question;
            detailsLabel.Text = selectedFAQ.Details;
           
            

        }
    }
}