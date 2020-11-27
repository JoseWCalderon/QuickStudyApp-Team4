﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuickStudyApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GooglePage : ContentPage
    {
        public GooglePage()
        {

            var browser = new WebView();
            {
                browser.Source = "https://www.google.com.au";
                Content = browser;
            }
        }


    }
}