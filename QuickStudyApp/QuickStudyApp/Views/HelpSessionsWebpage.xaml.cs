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
    public partial class HelpSessionsWebpage : ContentPage
    {
        public HelpSessionsWebpage()
        {
            var browser = new WebView();
            browser.Source = "https://unihub.qut.edu.au/students/events/filter?id=1101";
            Content = browser;
        }
    }
}