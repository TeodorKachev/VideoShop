using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            var customers = new List<Customer>()
            {
                new Customer { Name = "Pesho"},
                new Customer { Name = "Spiridon"}   
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        // Movies
        public ActionResult Index()
        {
            var movies = GetMovies();
            
            return View(movies);
        }

        private object GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Оркестър без име"},
                new Movie { Id = 2, Name = "Господин за един ден"}
            };
        }

        [Route("movies/released/{year:regex(\\d{4}):range(1950,2950)}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}