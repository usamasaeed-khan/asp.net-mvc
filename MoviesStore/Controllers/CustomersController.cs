using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MoviesStore.Models;


namespace MoviesStore.Controllers
{
    public class CustomersController : Controller
    {
        public List<Customer> GetCustomers()
        {
            var customers = new List<Customer>
            {
                new Customer {Id=1,Name="Customer 1"},
                new Customer {Id=2,Name="Customer 2"}
            };
            return customers;
        }
        // GET: Customers
        //public ActionResult Index()
        //{
        //    return View();
        //}
        [Route("Customers")]
        public ActionResult Index()
        {
            // to send data to view.
            return View(GetCustomers());
        }

        [Route("Customers/{id}")]
        public ActionResult Info(int Id)
        {
            Customer customer = null;
            foreach(Customer cust in GetCustomers())
            {
                if(cust.Id == Id)
                {
                    customer = cust;
                    break;
                }
            }
            if (customer == null) return HttpNotFound();
            
            else return View(customer);
        }

    }
}