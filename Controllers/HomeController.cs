using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission06_Ross.Models;
using System.Diagnostics;

namespace Mission06_Ross.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext _context;
        public HomeController(MovieContext temp) 
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            //Linq
            var submissions = _context.Movies
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
            _context.Movies.Include("Category").ToList();
            ViewBag.Categories = _context.Categories.ToList();
            return View("AddMovie", new Movie());
        }

        [HttpPost]
        public IActionResult AddMovie(Movie response)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(response); //Add record to the database
                _context.SaveChanges();

                return View("Confirmation", response);
            }
            else //Invalid data
            {
                ViewBag.Categories = _context.Categories.ToList();
                return View(response);
            }
            
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == id);

            ViewBag.Categories = _context.Categories.ToList();

            return View("AddMovie", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Movie updatedInfo) 
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies
                .Single(x => x.MovieId == id);

            return View(recordToDelete);
        }

        [HttpPost]
        public IActionResult Delete(Movie movie)
        {
            _context.Movies.Remove(movie);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
