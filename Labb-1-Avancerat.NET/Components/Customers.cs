using Labb_1_Avancerat.NET.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb_1_Avancerat.NET.Components
{
    public class Customers : ViewComponent
    {
        private readonly ICustomerRepository _customerRepo;

        public Customers(ICustomerRepository customerRepo)
        {
            _customerRepo = customerRepo;
        }

        public IViewComponentResult Invoke()
        {
            var customers = _customerRepo.GetAllCustomers().OrderBy(c => c.CustomerId);
            return View(customers);
        }
    }
}
