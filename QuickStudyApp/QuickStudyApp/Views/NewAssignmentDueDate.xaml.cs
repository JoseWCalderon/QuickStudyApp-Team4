using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickStudyApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using QuickStudyApp.Models;
using QuickStudyApp.Services;

namespace QuickStudyApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    
    public partial class NewAssignmentDueDate : ContentPage
    {
        public NewAssignmentDueDate()
        {
            InitializeComponent();
        }
        async void OnSaveButtonClicked(object sender, EventArgs e)

        {

            var note = (AssignmentDataControl)BindingContext;
            note.Date = DateTime.UtcNow;

            await QuickStudyApp.ViewModels.CalendarViewModel.DatabaseDue.SaveNoteAsync(note);

            await Navigation.PopAsync();

        }



        async void OnDeleteButtonClicked(object sender, EventArgs e)

        {

            var note = (AssignmentDataControl)BindingContext;

            await QuickStudyApp.ViewModels.CalendarViewModel.DatabaseDue.DeleteNoteAsync(note);

            await Navigation.PopAsync();

        }
    }
}