﻿using QuickStudyApp.Models;
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
    public partial class AskAQuestionPage : ContentPage
    {
        public AskAQuestionPage()
        {
            InitializeComponent();
        }

        private async void SubmitButton(object sender, EventArgs e)
        {
            //await DisplayAlert("Success", "Your message has been sent!", "Close");
            //await Application.Current.MainPage.Navigation.PopAsync(); //Remove the page currently on top.

            Question question = new Question()
            {
                QuestionDetail = questionEntry.Text
            };

            SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation);
            conn.CreateTable<Question>();
            int rows = conn.Insert(question);
            conn.Close();

            if (rows > 0)
                await DisplayAlert("Success", "Question submitted", "Close");
            else
                await DisplayAlert("Failure", "Question was not submitted", "Close");
        }
    }
}