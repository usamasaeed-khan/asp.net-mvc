using MoviesStore.Models;
using MoviesStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoviesStore.Controllers
{
    public class MoviesController : Controller
    {
        [Route("Movies")]
        public ActionResult Index()
        {
            var movies = new List<Movie>
            {
                new Movie {Id=1,Name="Movie 1"},
                new Movie {Id=2,Name="Movie 2"}
            };
            return View(movies);
        }
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };

            var customers = new List<Customer>
            {
                new Customer {Name="Customer 1"},
                new Customer {Name="Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            // to send data to view.
            return View(viewModel);
        }
    }
}