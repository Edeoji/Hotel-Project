﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Messages
    {
        public Messages() { }
        public Messages(string message)
        {
            Description = message;
        }
        public Messages(string message, int type)
        {
            Description = message;
            Type = type;
        }
        public Messages(string title, string message, int type)
        {
            Title = title;
            Description = message;
            Type = type;
        }

        public enum Category
        {
            Warning = 1,
            Error = 2,
            Information = 3
        }

        public int Type { get; set; }
        public int Number { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Advice { get; set; }
        public string Action { get; set; }
    }
}
