using Bug_Tracker.Data;
using Bug_Tracker.Models;
using Bug_Tracker.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace Bug_Tracker.Controllers
{
    public class UserController : Controller
    {
        private BugDbContext context;

        public UserController(BugDbContext dbContext)
        {   
            context = dbContext;
        }


        public IActionResult Add()
        {
            AddUserViewModel addUserViewModel = new AddUserViewModel();
            return View(addUserViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddUserViewModel addUserViewModel)
        {
            if (ModelState.IsValid)
            {
               
                User newUser = new User
                {
                    EmailAddress = addUserViewModel.EmailAddress,
                    Password = addUserViewModel.Password,
                    Admin = addUserViewModel.Admin,
                };

                context.Users.Add(newUser);
                context.SaveChanges();

                return Redirect("/");
            }

            return View();
        }

    }



}
 