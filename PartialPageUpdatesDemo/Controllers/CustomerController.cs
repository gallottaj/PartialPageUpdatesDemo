using Microsoft.AspNetCore.Mvc;
using PartialPageUpdatesDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialPageUpdatesDemo.Controllers
{
    public class CustomerController : Controller
    {
        List<CustomerModel> customers = new List<CustomerModel>();
        public CustomerController()
        {
            customers.Add(new CustomerModel { Id = 0, Name = "Sherry", Age = 42 });
            customers.Add(new CustomerModel { Id = 2, Name = "Jerry", Age = 22 });
            customers.Add(new CustomerModel { Id = 3, Name = "Kerry", Age = 56 });
            customers.Add(new CustomerModel { Id = 4, Name = "Mherry", Age = 49 });
            customers.Add(new CustomerModel { Id = 5, Name = "Therry", Age = 19 });
        }
    
        public IActionResult Index()
        {
            return View(customers);
        }
    }
}
