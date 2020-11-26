using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickStudyApp.Models
{
    public class Question
    {
        //using SQLite database
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(250)]
        public string QuestionDetail { get; set; }
    }
}
