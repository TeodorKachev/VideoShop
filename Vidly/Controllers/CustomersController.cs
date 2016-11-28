using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details()
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer { Name = "Pesho"},
                new Customer { Name = "Spiridon"}
            };

            return View(customers);
        }
    }
}