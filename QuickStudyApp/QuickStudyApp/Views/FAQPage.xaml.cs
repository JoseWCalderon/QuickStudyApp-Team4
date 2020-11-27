using QuickStudyApp.Data;
using QuickStudyApp.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuickStudyApp.Views
{
    public partial class FAQPage : ContentPage
    {
        //public IList<FAQ> FAQs { get; private set; }

        
       

        public FAQPage()
        {
            InitializeComponent();
            
            //BindingContext = this;

            //    FAQs = new List<FAQ>();
            //    FAQs.Add(new FAQ
            //    {
            //        Question = "How do i change my units?",
            //        Details = "provide the answer here"
            //    });

            //    FAQs.Add(new FAQ
            //    {
            //        Question = "How do i manage my calandar?",
            //        Details = "Details"
            //    });

            //    FAQs.Add(new FAQ
            //    {
            //        Question = "How do i change my assessment dates?",
            //        Details = "Details"
            //    });

            //    FAQs.Add(new FAQ
            //    {
            //        Question = "How do i find my team?",
            //        Details = "Details"
            //    });

            //    FAQs.Add(new FAQ
            //    {
            //        Question = "How do i contact my tutor?",
            //        Details = "Details"
            //    });

            //}
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            //the using statement provided in SQLite disposes/closes the connection without
            //having to worry about calling the close methods
            using(SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<Question>();
                var questions = conn.Table<Question>().ToList();
                questionListView.ItemsSource = questions;
            }


            ////read data from the database using SQlite

            ////establish a connection to the SQlite database
            //SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation);

            ////create a table of type question class
            //conn.CreateTable<Question>();

            ////using LINQ to change the table to a list method, that will store in questions
            //var questions = conn.Table<Question>().ToList();

            ////close the connection
            //conn.Close();
        }


        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
       {

            if (string.IsNullOrEmpty(e.NewTextValue))
            {
               // searchBar.ItemsSource = FAQData.FAQs;
            }
            else
            {
               // searchBar.ItemsSource = FAQData.FAQs.Where(x => x.Question.c(e.NewTextValue));
            }
            
            //{
            //    var FAQs = new List<FAQ>();

            //}
        }

        //private void SelectedFAQ_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{

        //    FAQ selectedFAQ = e.SelectedItem as FAQ;
        //    foreach (var FAQ in FAQData.FAQs)
        //    {
        //        if (selectedFAQ.QuestionID == FAQ.QuestionID)
        //        {
        //            Navigation.PushAsync(new FAQDetailsPage(selectedFAQ));
        //        }
        //    }
        //}

        //var FAQ = selectedFAQ.SelectedItem as FAQ;
        //FAQ selectedItem = e.SelectedItem as FAQ;
        ////push to another page in the app

        //await Shell.Current.GoToAsync("FAQDetailsPage");


        //private void TappedFAQ_ItemTapped(object sender, ItemTappedEventArgs e)
        //{
        //    FAQ TappedItem = e.Item as FAQ;
        //}

        async void QuestionClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("TypeOfQuestionPage");
        }

        private void questionListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedQuestion = questionListView.SelectedItem as Question;

            if (selectedQuestion != null)
            {
                Navigation.PushAsync(new FAQDetailsPage(selectedQuestion));
            }
        }

        //async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    string faqName = (e.CurrentSelection.FirstOrDefault() as FAQ).Question;

        //    await Shell.Current.GoToAsync($"faqdetails?name={faqName}");
        //}
    }

    
}