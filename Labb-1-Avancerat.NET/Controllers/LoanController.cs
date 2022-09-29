using Labb_1_Avancerat.NET.Models;
using Labb_1_Avancerat.NET.Models.Interfaces;
using Labb_1_Avancerat.NET.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb_1_Avancerat.NET.Controllers
{
    public class LoanController : Controller
    {
        private readonly ICustomerRepository _customerRepo;
        private readonly IBookRepository _bookRepo;
        private readonly ILoanOrderRepository _orderRepo;
        private readonly AppDbContext _context;

        public LoanController(IBookRepository bookRepo, ICustomerRepository customerRepo, ILoanOrderRepository orderRepo, AppDbContext context)
        {
            _bookRepo = bookRepo;
            _customerRepo = customerRepo;
            _orderRepo = orderRepo;
            _context = context;
        }

        public IActionResult Index()
        {
            var loanorders = _orderRepo.GetAllLoanOrders();
            return View(loanorders);
        }

        public IActionResult LoanOrder(int id)
        {
            var loanorder = _orderRepo.GetLoanOrderById(id);
            return View(loanorder);
        }

        public IActionResult AddLoanOrder(int id)
        {
            if (ModelState.IsValid)
            {
                if (id == 0)
                {
                    return View(new LoanOrder());
                }
                else
                {
                    return View(_context.LoanOrders.Find(id));
                }
            }
            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddLoanOrder([Bind("LoanOrderId,DateOfLoan,DateOfReturn,CustomerId,BookId")] LoanOrder loanorder)
        {
            if (ModelState.IsValid)
            {
                if (loanorder.LoanOrderId == 0)
                {
                    loanorder.DateOfLoan = DateTime.Now;
                    loanorder.DateOfReturn = DateTime.Now.AddDays(15);
                    _context.LoanOrders.Add(loanorder);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return NotFound("Something went Wrong");
                }
            }
            return View(loanorder);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var orderToDelete = await _context.LoanOrders.FindAsync(id);
            _context.LoanOrders.Remove(orderToDelete);

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
