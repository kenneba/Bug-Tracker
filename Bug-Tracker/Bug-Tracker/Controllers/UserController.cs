using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bug_Tracker.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Bug_Tracker.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }

        //public IActionResult Add(AddUserViewModel addUserViewModel)
        //{
            
        //    return View();
        //}
        
    }
}