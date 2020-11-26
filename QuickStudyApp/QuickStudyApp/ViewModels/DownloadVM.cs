using QuickStudyApp.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickStudyApp.ViewModels
{
    public class DownloadVM
    {
        //property is external access to this, using the DonwnloadCommand Class
        public DownloadCommand downloadCommand { get; set; }

        //contrustor that will call this method when this class is instantiated, if we call this
        //Method we are also creating a new instance of the Download Command
        public DownloadVM()
        {
            downloadCommand = new DownloadCommand(this);
        }

        
    }
}
