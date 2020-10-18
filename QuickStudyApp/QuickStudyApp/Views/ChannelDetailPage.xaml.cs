using System;
using System.Collections.Generic;
using QuickStudyApp.Models;
using Xamarin.Forms;

namespace QuickStudyApp.Views
{
    public partial class ChannelDetailPage : ContentPage
    {
        Channel selectedChannel;

        public ChannelDetailPage(Channel selectedChannel)
        {
            InitializeComponent();

            this.selectedChannel = selectedChannel;

            //to the front view here
            ChannelName.Text = selectedChannel.Name;
            ChannelDetail.Text = selectedChannel.Description;



        }

    }
}
