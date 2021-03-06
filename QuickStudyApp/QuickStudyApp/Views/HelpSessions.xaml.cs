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
    public partial class HelpSessions : ContentPage
    {
        public HelpSessions()
        {
            InitializeComponent();
        }

        private async void HelpSearchClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HelpSessionsWebpage());
        }
    }
}