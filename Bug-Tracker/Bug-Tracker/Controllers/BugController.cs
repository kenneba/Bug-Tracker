using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bug_Tracker.Models;
using Bug_Tracker.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Bug_Tracker.Controllers
{
    public class BugController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index(AddBugViewModel bugViewModel)
        {
            Bug newBug = new Bug
            {
                Date = AddBugViewModel.Date,
                Subject = AddBugViewModel.Subject,
                Description = AddBugViewModel.Description,

            };
            return View();
        }
    }
}