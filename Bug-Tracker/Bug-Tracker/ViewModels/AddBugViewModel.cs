using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Bug_Tracker.Models;



namespace Bug_Tracker.ViewModels
{
    public class AddBugViewModel
    {
        [Required]
        [Display(Date = "Date")]
        public string Date { get; set; }

        [Required]
        [Display(Subject = "Subject")]
        public string Subject { get; set; }

        [Required]
        [Display(Description = "Description")]
        public string Description { get; set; }

        public AddBugViewModel()
        {
        }
    }
}
