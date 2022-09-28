using Labb_1_Avancerat.NET.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb_1_Avancerat.NET.Models.Repositorys
{
    public class LoanOrderRepository : ILoanOrderRepository
    {
        private readonly AppDbContext _context;

        public LoanOrderRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<LoanOrder> GetAllLoanOrders()
        {
            return _context.LoanOrders.Include(c => c.Customer).Include(b => b.Book).Include(b=>b.Book.Category);
        }

        public LoanOrder GetLoanOrderById(int id)
        {
            return _context.LoanOrders.Include(c => c.Customer).Include(b => b.Book).FirstOrDefault(l => l.LoanOrderId == id);
        }
    }
}
