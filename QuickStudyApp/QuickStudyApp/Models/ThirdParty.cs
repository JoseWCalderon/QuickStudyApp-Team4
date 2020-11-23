using System;
using System.Collections.Generic;
using System.Text;

namespace QuickStudyApp.Data
{
    public class ThirdParty
    {
        public string Name { get; set; }
        public string LinkUrl { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }
}
