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
        private readonly BugDbContext context;

        public BugController(BugDbContext dbContext)
        {
            context = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            AddBugViewModel addBugViewModel = new AddBugViewModel();
            return View(addBugViewModel);
        }

       
    }
}

       
        //
        // The detail display for a given Job at URLs like /Job?id=17
       // public IActionResult Index(int ID)
        
            // get the Bug with the given ID and pass it into the view
           // Bug bug = BugDbContext.Find(ID);

            //return View(bug);
        
        //ic IActionResult UserBugs(int UserID)


        //public IActionResult Add(AddBugViewModel bugViewModel)
        //{
          //  Bug newBug = new Bug
            

          ///      CreatedDate = bugViewModel.CreatedDate,
             ///   Subject = bugViewModel.Subject,
                ///Description = bugViewModel.Description,

            

           // return View();
        
    

   