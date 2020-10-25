using System;
using System.Collections.Generic;
using QuickStudyApp.Data;
using QuickStudyApp.Models;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace QuickStudyApp.Views
{
    public partial class ChannelPage : ContentPage
    {
        public ChannelPage()
        {
            InitializeComponent();

            BindingContext = this;


        }

        private void selectedChannel_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            Channel selectedChannel = e.SelectedItem as Channel;
            foreach (var Channel in ChannelData.channels)
            {
                if (selectedChannel.Name == Channel.Name)
                {
                    Navigation.PushAsync(new ChannelDetailPage(selectedChannel));
                }
            }
        }

        private void tappedChannel_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Channel tappedItem = e.Item as Channel;
        }

        async void ImageButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Shell.Current.GoToAsync("ContactPage");
        }

        async void Files_Clicked(System.Object sender, System.EventArgs e)
        {
            await Shell.Current.GoToAsync("FilePage");
        }

        private async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Launcher.OpenAsync("https://teams.microsoft.com");
        }
    }
}
