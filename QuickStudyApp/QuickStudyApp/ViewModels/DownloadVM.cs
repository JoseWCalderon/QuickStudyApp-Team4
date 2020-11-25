using QuickStudyApp.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickStudyApp.ViewModels
{
    public class DownloadVM
    {
        public DownloadCommand downloadCommand { get; set; }
        public DownloadVM()
        {
            downloadCommand = new DownloadCommand(this);
        }

        public void Download()
        {
            //TODO
        }
    }
}
