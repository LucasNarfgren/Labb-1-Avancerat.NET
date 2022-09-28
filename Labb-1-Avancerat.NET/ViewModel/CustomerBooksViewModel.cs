using Labb_1_Avancerat.NET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb_1_Avancerat.NET.ViewModel
{
    public class CustomerBooksViewModel
    {
        public Customer Customer { get; set; }
        public IEnumerable<LoanOrder> LoanOrders { get; set; }
    }
}
