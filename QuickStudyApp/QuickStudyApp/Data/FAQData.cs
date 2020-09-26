using QuickStudyApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickStudyApp.Data
{
    public static class FAQData
    {
        //create a list of FAQs that we can access later in the app
        public static IList<FAQ> FAQs { get; private set; }
        static FAQData()
        {
            
            FAQs = new List<FAQ>();
            FAQs.Add(new FAQ
            {
                QuestionID = 1,
                Question = "How do i change my units?",
                Details = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Maiores veniam autem ad laboriosam officiis dolores," +
                " quia incidunt! Cum, eos? Ratione, repudiandae? Nihil sint repudiandae mollitia deserunt obcaecati magni quae numquam."
            });

            FAQs.Add(new FAQ
            {
                QuestionID = 2,
                Question = "How do i manage my calandar?",
                Details = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Maiores veniam autem ad laboriosam officiis dolores," +
                " quia incidunt! Cum, eos? Ratione, repudiandae? Nihil sint repudiandae mollitia deserunt obcaecati magni quae numquam."
            });

            FAQs.Add(new FAQ
            {
                QuestionID = 3,
                Question = "How do i change my assessment dates?",
                Details = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Maiores veniam autem ad laboriosam officiis dolores," +
                " quia incidunt! Cum, eos? Ratione, repudiandae? Nihil sint repudiandae mollitia deserunt obcaecati magni quae numquam."
            });

            FAQs.Add(new FAQ
            {
                QuestionID = 4,
                Question = "How do i find my team?",
                Details = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Maiores veniam autem ad laboriosam officiis dolores," +
                " quia incidunt! Cum, eos? Ratione, repudiandae? Nihil sint repudiandae mollitia deserunt obcaecati magni quae numquam."
            });

            FAQs.Add(new FAQ
            {
                QuestionID = 5,
                Question = "How do i contact my tutor?",
                Details = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Maiores veniam autem ad laboriosam officiis dolores," +
                " quia incidunt! Cum, eos? Ratione, repudiandae? Nihil sint repudiandae mollitia deserunt obcaecati magni quae numquam."
            });

            
        }
    }
}
