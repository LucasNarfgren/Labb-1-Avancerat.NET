using Labb_1_Avancerat.NET.Models;
using Labb_1_Avancerat.NET.Models.Interfaces;
using Labb_1_Avancerat.NET.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Labb_1_Avancerat.NET.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IBookRepository _bookRepository;
        private readonly ILoanOrderRepository _loanorderRepo;
        private readonly AppDbContext _context;

        public CustomerController(ICustomerRepository customerRepository, IBookRepository bookRepository, ILoanOrderRepository loanorderRepo, AppDbContext context)
        {
            _customerRepository = customerRepository;
            _bookRepository = bookRepository;
            _loanorderRepo = loanorderRepo;
            _context = context;
        }


        public IActionResult Index()
        {
            var customers = _customerRepository.GetAllCustomers();
            return View(customers);
        }
        [HttpGet("Customer/{id}")]
        public IActionResult Customer(int id, CustomerBooksViewModel customerBooksViewModel)
        {
            customerBooksViewModel = new CustomerBooksViewModel
            {
                Customer = _customerRepository.GetCustomerById(id),
                LoanOrders = _loanorderRepo.GetAllLoanOrders().Where(c => c.CustomerId == id).OrderBy(c => c.DateOfLoan)
            };
            //var customer = _customerRepository.GetCustomerById(id);
            return View(customerBooksViewModel);
        }



        public IActionResult AddOrEditCustomer(int id)
        {
            if (id == 0)
            {
                return View(new Customer());
            }
            else
            {
                return View(_context.Customers.Find(id));
            }
        }
   
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEditCustomer([Bind("CustomerId,FirstName,LastName,Email")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                if (customer.CustomerId == 0)
                {
                    
                    _context.Add(customer);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(customer);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customerToDelete = await _context.Customers.FindAsync(id);
            _context.Customers.Remove(customerToDelete);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
