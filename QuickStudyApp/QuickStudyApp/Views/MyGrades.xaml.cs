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
    public partial class MyGrades : ContentPage
    {
        public MyGrades()
        {
            var mygradesbrowser = new WebView();
            mygradesbrowser.Source = "https://blackboard.qut.edu.au/webapps/bb-social-learning-bb_bb60/execute/mybb?cmd=display&toolId=MyGradesOnMyBb";
            Content = mygradesbrowser;
        }
    }
} 