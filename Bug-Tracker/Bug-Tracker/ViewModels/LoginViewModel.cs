using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Bug_Tracker.Models;
using Bug_Tracker.ViewModels;




namespace Bug_Tracker.ViewModels
{
    public class LoginViewModel { 
        [Required] 
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required]  
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public LoginViewModel() { }
    }
}
