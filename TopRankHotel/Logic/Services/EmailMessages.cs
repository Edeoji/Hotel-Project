﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Services
{
    public class EmailMessages
    {
        public EmailMessages()
        {
            ToAddresses = new List<EmailAddress>();
            FromAddresses = new List<EmailAddress>();
        }

        public List<EmailAddress> ToAddresses { get; set; }

        public List<EmailAddress> FromAddresses { get; set; }

        public string Subject { get; set; }

        public string Content { get; set; }

    }
}
