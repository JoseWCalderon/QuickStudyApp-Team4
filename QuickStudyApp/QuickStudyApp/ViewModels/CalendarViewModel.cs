using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;
using System.IO;
using QuickStudyApp.Views;
using QuickStudyApp.Models;
using System.Threading.Tasks;
using PCLStorage;
using FileSystem = PCLStorage.FileSystem;
using QuickStudyApp.Services;

namespace QuickStudyApp.ViewModels
{
    public class CalendarViewModel : CalendarModelControls
    {
        public Command Timetable { get; }
        public Command AssignmentDueDate { get; }
        public Command NotePage { get; }
        public CalendarViewModel()
        {
            Title = "Calendar";
            Timetable = new Command(OnSchedule);
            AssignmentDueDate = new Command(OnAssignmentDue);
            NotePage = new Command(OnNotes);
        }

        private async void OnSchedule(object obj)
        {

            await Shell.Current.GoToAsync(nameof(Schedule));
        }
        private async void OnAssignmentDue(object obj)
        {

            await Shell.Current.GoToAsync(nameof(AssignmentDue));


        }
        private async void OnNotes(object obj)
        {

            await Shell.Current.GoToAsync(nameof(NotesPage));


        }

        static NoteDatabase database;
        static AssignmentData databaseDue;

        static ScheduleData databaseSchedule;
        public static NoteDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new NoteDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Notes.db3"));
                }
                return database;
            }
        }
        public static ScheduleData DatabaseSchedule
        {
            get
            {
                if (databaseSchedule == null)
                {
                    databaseSchedule = new ScheduleData(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Notes.db3"));
                }
                return databaseSchedule;
            }
        } 
        
        public static AssignmentData DatabaseDue
        {
            get
            {
                if (databaseDue == null)
                {
                    databaseDue = new AssignmentData(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Notes.db3"));
                }
                return databaseDue;
            }
        }
        
    }
}