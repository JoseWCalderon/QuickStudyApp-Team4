using QuickStudyApp.Data;
using QuickStudyApp.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Markup;
using Xamarin.Forms.Markup.LeftToRight;
using Xamarin.Forms.Xaml;

namespace QuickStudyApp.Views

{
    [QueryProperty("Details", "details")]
    public partial class FAQDetailsPage : ContentPage
    {
        //public variable of type Question
        Question selectedQuestion;
        //FAQ selectedFAQ;
        

        public string Details 
        {
            set
            {
                //BindingContext = FAQData.Questions.FirstOrDefault(m => m.Question == Uri.UnescapeDataString(value));
            }
        }


        public FAQDetailsPage(Question selectedQuestion)
        {
            InitializeComponent();

            //contructor method to pass this variable to the global variable
            this.selectedQuestion = selectedQuestion;

            //display to the front end, the questionEntry.text field update
            //it with the selected question
            questionEntry.Text = selectedQuestion.QuestionDetail;

            //this.selectedFAQ = selectedFAQ;

            ////to the front view here
            //questionLabal.Text = selectedFAQ.Question;
            //detailsLabel.Text = selectedFAQ.Details;
           
            

        }

        //The update button event handler will use the SQLite method to update the question, this is known
        //by the Id that is in the selectedQuestion inside the data itself.
        private void updateButton_Clicked(object sender, EventArgs e)
        {
            //update the selected question with the questionEntry field in the frontend
            selectedQuestion.QuestionDetail = questionEntry.Text;

            using(SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<Question>();
                int rows = conn.Update(selectedQuestion);

                if (rows > 0)
                    DisplayAlert("Success", "Question Updated", "Close");
                else
                    DisplayAlert("Failure", "Question failed to be updated", "Close");
            }
        }

        //The delete method has the Id inside the selectedQuestion and is deleted by Id through SQLiteConnection, we get the Id when we read the database.
        //so when we get it as a question, the selectedQuestion has the Id already.
        private void deleteButton_Clicked(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<Question>();
                int rows = conn.Delete(selectedQuestion);

                if (rows > 0)
                    DisplayAlert("Success", "Question deleted", "Close");
                else
                    DisplayAlert("Failure", "Question failed to be deleted", "Close");
            }
        }
    }
}