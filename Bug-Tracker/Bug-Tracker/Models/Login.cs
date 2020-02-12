using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bug_Tracker.Models
{
    public class Login
    {
        public int ID { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public int AdminID { get; set; }



    }
}
