using System;
using Microsoft.AspNetCore.Mvc;

namespace Lab11_Intro_To_MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Results()
        {
            return View();
        }
    }
}
