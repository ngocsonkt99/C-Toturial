﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bai_5.Models
{
    public class MailInfo
    {
        public string From { get; set; }
        public string Password { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

    }
}