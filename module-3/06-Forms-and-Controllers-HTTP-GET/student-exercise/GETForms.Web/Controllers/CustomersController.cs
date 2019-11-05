using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GETForms.Web.DAL;
using GETForms.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace GETForms.Web.Controllers
{
    public class CustomersController : Controller
    {
        string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=dvdstore;Integrated Security=True";

        public IActionResult Index()
        {

            CustomerView viewCustomer = new CustomerView();
            return View(viewCustomer);

        }

        public IActionResult GetCustomers(CustomerView customer)
        {
            CustomerDAO dao = new CustomerDAO(connectionString);
            IList<Customer> customers = dao.SearchForCustomers(customer.Name, customer.SortBy);

            return View(customers);
        }

    }
}
