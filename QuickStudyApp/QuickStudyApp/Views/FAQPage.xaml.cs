﻿using QuickStudyApp.Models;
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
            BindingContext = this;

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

            private void searchBar_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            FAQ selectedItem = e.SelectedItem as FAQ;
            //push to another page in the app
            await Shell.Current.GoToAsync("FAQDetailsPage");
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            FAQ tappedItem = e.Item as FAQ;
        }

        async void QuestionClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("TypeOfQuestionPage");
        }

        //async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    string faqName = (e.CurrentSelection.FirstOrDefault() as FAQ).Question;

        //    await Shell.Current.GoToAsync($"faqdetails?name={faqName}");
        //}
    }
}