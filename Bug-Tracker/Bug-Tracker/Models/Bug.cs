﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bug_Tracker.Models
{
    public class Bug
    {
        public int ID { get; set; }

        public string CreatedDate { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public string LastModifiedDate { get; set; }
        public int AdminID { get; set; }
        public string Status { get; set; }
        public int CommentID { get; set; }
    }
}
