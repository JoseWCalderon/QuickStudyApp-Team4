using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace QuickStudyApp.Models
{
    public class NoteDataControlInformation
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }

        public string NoteTitle { get; set; }
        public string Filename { get; set; }

        
    }
}
