using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickStudyApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using QuickStudyApp.Models;

namespace QuickStudyApp.Views
{
    public partial class AssignmentDue : ContentPage
    {
        public AssignmentDue()
        {
            //InitializeComponent();
        }

        
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            //listView.ItemsSource = await QuickStudyApp.ViewModels.CalendarViewModel.DatabaseDue.GetNotesAsync();

        }

        async void OnNoteAddedClicked(object sender, EventArgs e)

        {

            await Navigation.PushAsync(new NewAssignmentDueDate

            {

               // BindingContext = new AssignmentDataControl()

            });

        }


        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)

        {

            if (e.SelectedItem != null)

            {

                await Navigation.PushAsync(new NewAssignmentDueDate

                {

                   // BindingContext = e.SelectedItem as AssignmentDataControl

                });

            }

        }

    }

}
