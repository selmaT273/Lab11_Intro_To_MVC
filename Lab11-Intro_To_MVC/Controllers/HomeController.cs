using System;
using System.Collections.Generic;
using Lab11_Intro_To_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab11_Intro_To_MVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(int startYear, int endYear)
        {
            return RedirectToAction("Results", new { startYear, endYear });
        }

        public IActionResult Results(int startYear, int endYear)
        {
            return View(PersonOfTheYear.GetPeople(startYear, endYear));
        }
    }
}
