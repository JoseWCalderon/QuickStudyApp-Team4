using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace QuickStudyApp.Data
{
    public class ThirdPartyData : ContentPage
    {
        public IList<ThirdParty> ThirdParties { get; private set; }

        public ThirdPartyData()
        {
            ThirdParties = new List<ThirdParty>();
            ThirdParties.Add(new ThirdParty
            {
                Name = "First Application",
                LinkUrl = ""
            });

            BindingContext = this;
        }
            

              

            
    }
}
