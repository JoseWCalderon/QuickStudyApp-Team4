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
            Question question = new Question()
            {
                QuestionDetail = questionEntry.Text
            };

            SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation);
            conn.CreateTable<Question>();
            int rows = conn.Insert(question);
            conn.Close();

            if (rows > 0)
                DisplayAlert("Success", "Question submitted", "Close");
            else
               DisplayAlert("Failure", "Question was not submitted", "Close");
        }
    }
}