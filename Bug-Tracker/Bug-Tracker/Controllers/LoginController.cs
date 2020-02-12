using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Bug_Tracker.Data;
using Bug_Tracker.Models;
using Bug_Tracker.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Bug_Tracker.Controllers
{
    public class LoginController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        //Returns Login view
        //public IActionResult Add()
        //{
        //    return View();
        //}


        public BugDbContext context;
        public LoginController(BugDbContext dbContext)
        {
            context = dbContext;
        }



        public IActionResult Add(NewLoginViewModel newLoginViewModel)
        {
            Login newLogin = new Login
            {

                EmailAddress = newLoginViewModel.EmailAddress,
                Password = newLoginViewModel.Password

            };
            context.Logins.Add(newLogin);
            context.SaveChanges();

            return View(newLoginViewModel);
        }



    }

}