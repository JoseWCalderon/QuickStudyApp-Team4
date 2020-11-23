using System;
using System.Collections.Generic;
using System.Text;

namespace QuickStudyApp.Models
{
    class Enrollment
    {
        public string StudentID { get; set; }

        // public string FirstName { get; set; }

        public string Subject { get; set; }

        public DateTime DateRegister { get; set; }


        //request the collection of properties from the Student class
        public IList <Student> Students { get; set; }

        //request the collection of properties from the Student class
        public IList <Subject> Subjects { get; set; }
    }

}

