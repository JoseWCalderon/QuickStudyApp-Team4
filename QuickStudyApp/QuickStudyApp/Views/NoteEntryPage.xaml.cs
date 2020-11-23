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
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class NoteEntryPage : ContentPage

    {

        public NoteEntryPage()

        {

            InitializeComponent();

        }



        async void OnSaveButtonClicked(object sender, EventArgs e)

        {

            var note = (NoteDataControlInformation)BindingContext;

            note.Date = DateTime.UtcNow;

            //await CalendarViewModel.Database.SaveNoteAsync(note);

            await Navigation.PopAsync();

        }



        async void OnDeleteButtonClicked(object sender, EventArgs e)

        {

            var note = (NoteDataControlInformation)BindingContext;

           // await CalendarViewModel.Database.DeleteNoteAsync(note);

            await Navigation.PopAsync();

        }

    }

}
