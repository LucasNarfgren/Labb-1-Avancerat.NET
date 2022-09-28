using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb_1_Avancerat.NET.Models.Interfaces
{
    public interface ILoanOrderRepository
    {
        IEnumerable<LoanOrder> GetAllLoanOrders();
        LoanOrder GetLoanOrderById(int id);
    }
}
