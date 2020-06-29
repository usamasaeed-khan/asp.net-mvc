using MoviesStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoviesStore.ViewModels
{

    // View models are used for using data from multiple models(instead of just one) in a view. 
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}