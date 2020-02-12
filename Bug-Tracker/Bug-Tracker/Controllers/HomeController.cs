using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;
using Microsoft.Extensions.Logging;
using Bug_Tracker.Models;
using Bug_Tracker.Data;
using Microsoft.AspNetCore.Http;


namespace Bug_Tracker.Controllers
{
    public class HomeController : Controller
    {

        private BugDbContext context;

        public HomeController(BugDbContext dbContext)
        {
            context = dbContext;
        }


        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Login()
        {
            return View();
        }


        [Route("login")]
        [HttpPost]
        public ActionResult Login(string emailaddress, string password)
        {
            if (ModelState.IsValid)
            {
                    var obj = context.Users.Where(a => a.EmailAddress.Equals(emailaddress) && a.Password.Equals(password)).FirstOrDefault();
                    if (obj != null)
                    {
                        HttpContext.Session.SetString("emailaddress", emailaddress);
                        return View("Welcome");
                    }
                
            }
            return View("Index");
        }

        [Route("logout")]
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("EmailAddress");
            return RedirectToAction("Index");
        }
    }
    
}  

