using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using QuickStudyApp.Models;
using System.IO;
using QuickStudyApp.Services;
using QuickStudyApp.ViewModels;

namespace QuickStudyApp.Views
{


    public partial class NotesPage : ContentPage

    {

        public NotesPage()

        {

            InitializeComponent();

        }



        protected override async void OnAppearing()

        {

            base.OnAppearing();
            listView.ItemsSource = await CalendarViewModel.Database.GetNotesAsync();

        }



        async void OnNoteAddedClicked(object sender, EventArgs e)

        {

            await Navigation.PushAsync(new NoteEntryPage

            {

                BindingContext = new NoteDataControl()

            });

        }



        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)

        {

            if (e.SelectedItem != null)

            {

                await Navigation.PushAsync(new NoteEntryPage

                {

                    BindingContext = e.SelectedItem as NoteDataControl

                });

            }

        }

    }

}