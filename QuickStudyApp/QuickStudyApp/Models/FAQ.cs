using System;
using System.Collections.Generic;
using System.Text;

namespace QuickStudyApp.Models
{
    public class FAQ
    {
        public int QuestionID { get; set; }
        public string Question { get; set; }

        public string Details { get; set; }


        public override string ToString()
        {
            return Question;
        }
    }
}
