using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bug_Tracker.Models
{
    public class Bug
    {
        private int TicketID { get; set; }
        public string Date { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
    }
}
