using QuickStudyApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickStudyApp.Data
{
    public static class FAQData
    {
        public static IList<FAQ> FAQs { get; private set; }
        static FAQData()
        {
            
            FAQs = new List<FAQ>();
            FAQs.Add(new FAQ
            {
                QuestionID = 1,
                Question = "How do i change my units?",
                Details = "provide the answer here"
            });

            FAQs.Add(new FAQ
            {
                QuestionID = 2,
                Question = "How do i manage my calandar?",
                Details = "Details"
            });

            FAQs.Add(new FAQ
            {
                QuestionID = 3,
                Question = "How do i change my assessment dates?",
                Details = "Details"
            });

            FAQs.Add(new FAQ
            {
                QuestionID = 4,
                Question = "How do i find my team?",
                Details = "Details"
            });

            FAQs.Add(new FAQ
            {
                QuestionID = 5,
                Question = "How do i contact my tutor?",
                Details = "Details"
            });

            
        }
    }
}
