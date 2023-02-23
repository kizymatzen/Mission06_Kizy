using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            //If Valid
            if (ModelState.IsValid)
            {
                MovieContext.Add(ar);
                MovieContext.SaveChanges();
                return View("Confirmation", ar);
            }
            else //If Invalid
            {
                ViewBag.Categories = MovieContext.Categories.ToList();
    

                return View(ar);
            }
            
        }

        public IActionResult MovieList()
        {
            var applications = MovieContext.Responses
                .Include(x => x.Category)
                .OrderBy(x => x.Title)
                .ToList();
            return View(applications);
        }

        [HttpGet]
        public IActionResult Edit (int applicationid)
        {
            ViewBag.Categories = MovieContext.Categories.ToList();

           var application = MovieContext.Responses.Single(x => x.ApplicationId == applicationid);

            return View("MovieForm", application);
        }

        [HttpPost]
        public IActionResult Edit (ApplicationResponse re)
        {
            MovieContext.Update(re);
            MovieContext.SaveChanges();

            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete(int applicationid)
        {
            var application =  MovieContext.Responses.Single(x => x.ApplicationId == applicationid);

            return View(application);
        }

        [HttpPost]
        public IActionResult Delete(ApplicationResponse ar)
        {

            MovieContext.Responses.Remove(ar);
            MovieContext.SaveChanges();

            return RedirectToAction("MovieList");
        }

    }
}
