using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace QuickStudyApp.Models
{
    public class AssignmentDataControl
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Duedate { get; set; }
        public string Description { get; set; }
        public string ClassInfo { get; set; }
        public string ClassDate { get; set; }
        public DateTime Date { get; set; }
        public DateTime OnScheduleTime { get; set; }

        public string Filename { get; set; }


    }
}
