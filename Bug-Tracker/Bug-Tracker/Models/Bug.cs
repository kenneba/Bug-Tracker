using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bug_Tracker.Models
{
    public class Bug
    {
        private int BugID { get; set; }
        public string BugDate { get; set; }
        public string BugSubject { get; set; }
        public string BugDescription { get; set; }
    }
}
