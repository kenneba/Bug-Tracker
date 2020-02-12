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
    public class UserController : Controller
    {
        private BugDbContext context;
        public UserController(BugDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add(AddUserViewModel userViewModel)
        {
            User newUser = new User
            {

                Name = userViewModel.Name,
                EmailAddress = userViewModel.EmailAddress,
                Password = userViewModel.Password,
                Role = userViewModel.Role
            };
            context.Users.Add(newUser);
            context.SaveChanges();

            return View(userViewModel);
        }

    }
}