﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Entity
{
    public class Email
    {
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }
        public string Body { get; set; }
        public string Subject { get; set; }
        public string Password { get; set; }



    }
}
