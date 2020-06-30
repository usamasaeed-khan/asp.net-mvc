using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MoviesStore.Models;
using System.Data.Entity; // to use.Include()


namespace MoviesStore.Controllers
{
    public class CustomersController : Controller
    {
        // Declaring db context for querying data.
        private ApplicationDbContext _context;

        public CustomersController()
        {
            // Initializing db context in constructor.
            _context = new ApplicationDbContext();

        }

        // Disposing db context is necessary hence we overrirde our dispose method.
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        

        [Route("Customers")]
        public ActionResult Index()
        {
            /* 
               1 - Customers is the db set we created before for Customer Model.

               2 - Query is not executed yet its executed when we iterate through 
                   customers in View, hence we use ToList() method to 
                   execute it immediately.

               3 - Calling .Include() loads MembershipType data too,
                   not using it will give null object reference if we use 
                   @customer.MembershipType.{AnyPropertyOfMembershipTypeModel}.
            */

            var customers = _context.Customers.Include(c => c.MembershipType).ToList();

            // to send data to view.
            return View(customers);
        }

        [Route("Customers/{id}")]
        public ActionResult Info(int id)
        {
            // Query will be immediately executed because of single or default method.
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            
            if (customer == null) 
                return HttpNotFound();
            
            return View(customer);
        }

    }
}