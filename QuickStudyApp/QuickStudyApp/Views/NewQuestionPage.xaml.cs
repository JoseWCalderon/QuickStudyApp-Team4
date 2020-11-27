using QuickStudyApp.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuickStudyApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewQuestionPage : ContentPage
    {
        public NewQuestionPage()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            //create an object/data of type question class when this button is clicked
            Question question = new Question()
            {
                QuestionDetail = questionEntry.Text
            };

            //create and open a new connection to the database
            SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation);

            //create a table of type Question class
            conn.CreateTable<Question>();

            //insert another row of type Question class to the database
            int rows = conn.Insert(question);

            //close the database connection
            conn.Close();

            //check here if a row has been inserted, check condition
            if (rows > 0)
                DisplayAlert("Success", "Question submitted", "Close");
            else
               DisplayAlert("Failure", "Question was not submitted", "Close");
        }
    }
}