using System;
using System.Collections.Generic;
using QuickStudyApp.Models;

namespace QuickStudyApp.Data
{
    public static class ChannelData
    {
        public static IList<Channel> channels { get; private set; }

        static ChannelData()
        {
            channels = new List<Channel>();
            channels.Add(new Channel
            {
                Name = "# General",
                Description = "Students can post anything about this unit in this channel!"
            });

            channels.Add(new Channel
            {
                Name = "# IAB330 Team4",
                Description = "This channel is for team 4 to talk about assignment 1 and assignment 2!"
            });

            channels.Add(new Channel
            {
                Name = "# WED 5PM (Hamish)",
                Description = "This channel is for the discussion of the students in the workshop at 5pm on Wednesday!"
            });

            channels.Add(new Channel
            {
                Name = "# Questions",
                Description = "Students can post any questions about this unit in this channel!"
            });
        }
    }
}
