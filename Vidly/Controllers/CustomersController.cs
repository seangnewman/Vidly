using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {

        // Add DB Context to access the database
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        //Dispose DBContext once access completed
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
        // End DBContext

        public ViewResult Index()
        {
            //var customers = GetCustomers();
            // Get customers from database

            var customers = _context.Customers.Include(c => c.MembershipType).ToList();   // Executes query immediatly when .ToList() method added, otherwise omit
             
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            //var customer = GetCustomers().SingleOrDefault(c => c.Id == id);
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

      
    }
}