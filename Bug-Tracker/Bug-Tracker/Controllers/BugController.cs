using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bug_Tracker.Data;
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

        private readonly BugDbContext context;

        public BugController(BugDbContext dbContext)
        {
            context = dbContext;
        }
        //public IActionResult Add()
        //{
        //    AddBugViewModel bugViewModel = new AddBugViewModel bugViewModel()
        //}

        public IActionResult Add(AddBugViewModel bugViewModel)
        {
            Bug newBug = new Bug
            {

                CreatedDate = bugViewModel.CreatedDate,
                Subject = bugViewModel.Subject,
                Description = bugViewModel.Description,

            };

            return View();
        }
    }
}