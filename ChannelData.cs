﻿using System;
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
                Destription = "Students can post anything about this unit in this channel!"
            });

            channels.Add(new Channel
            {
                Name = "# Assignment 1",
                Destription = "Students can post anything about Assignment 1 in this channel!"
            });

            channels.Add(new Channel
            {
                Name = "# Assignment 2",
                Destription = "Students can post anything about Assignment 2 in this channel!"
            });

            channels.Add(new Channel
            {
                Name = "# Questions",
                Destription = "Students can post any questions about this unit in this channel!"
            });
        }
    }
}
