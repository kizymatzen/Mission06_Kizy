using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission06_Kizy.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_Kizy.Controllers
{
    public class HomeController : Controller
    {
        private MovieApplicationContext MovieContext { get; set; }

        //Constructor
        public HomeController( MovieApplicationContext someName)
        {
            MovieContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieForm()
        {
            ViewBag.Categories = MovieContext.Categories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult MovieForm(ApplicationResponse ar)
        {
            MovieContext.Add(ar);
            MovieContext.SaveChanges();
            return View("Confirmation", ar);
        }

        public IActionResult MovieList()
        {
            var applications = MovieContext.Responses.OrderBy(x => x.Title)
                .ToList();

            return View(applications);
        }
    }
}
