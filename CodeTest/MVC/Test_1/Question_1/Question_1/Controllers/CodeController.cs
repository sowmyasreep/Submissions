using Question_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Question_1.Controllers
{
    public class CodeController : Controller
    {
        private NorthwindEntities db = new NorthwindEntities();
        // GET: Code
        public ActionResult Index()
        {
            var germanCustomers = db.Customers.Where(c => c.Country == "Germany").ToList();
            return View(germanCustomers);
        }
        public ActionResult GetCustomerDetails()
        {
            var customerDetails = db.Orders
                .Where(o => o.OrderID == 10248)
                .Select(o => new CustomerDetailsViewModel
                {
                    CustomerID = o.Customer.CustomerID,
                    ContactName = o.Customer.ContactName,
                
            })
                .FirstOrDefault();

            return View(customerDetails);
        }

    }
}





   

 

   