using Microsoft.AspNetCore.Mvc;
using Mission06_Ross.Models;
using System.Diagnostics;

namespace Mission06_Ross.Controllers
{
    public class HomeController : Controller
    {
        private MovieSubmissionContext _context;
        public HomeController(MovieSubmissionContext temp) 
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            //Linq
            var submissions = _context.MovieSubmissions
                .OrderBy(x => x.Title).ToList();
            return View(submissions);
        }

        public IActionResult GetToKnowJoel()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddMovie()
        {
            ViewBag.Categories = _context.Categories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(MovieSubmission response)
        {
            _context.MovieSubmissions.Add(response); //Add record to the database
            _context.SaveChanges();

            return View("Confirmation", response);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.MovieSubmissions
                .Single(x => x.MovieId == id);

            ViewBag.Categories = _context.Categories.ToList();

            return View("AddMovie", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(MovieSubmission updatedInfo) 
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
