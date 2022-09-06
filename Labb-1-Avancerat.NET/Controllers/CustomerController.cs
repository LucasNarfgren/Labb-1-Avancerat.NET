using Labb_1_Avancerat.NET.Models;
using Microsoft.AspNetCore.Mvc;

namespace Labb_1_Avancerat.NET.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }


        public IActionResult Index()
        {
            var customers = _customerRepository.GetAllCustomers();
            return View(customers);
        }
        [HttpGet("Customer/{id}")]
        public IActionResult Customer(int id)
        {
            var customer = _customerRepository.GetCustomer(id);
            return View(customer);
        }

        

    }
}
