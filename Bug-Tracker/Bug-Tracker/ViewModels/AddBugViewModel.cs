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
    public class AddBugViewModel
    {
        [Required] 
        public string CreatedDate { get; set; }

        [Required]        
        public string Subject { get; set; }

        [Required]
        [Display(Description = "Description")]
        public string Description { get; set; }

    }
}
