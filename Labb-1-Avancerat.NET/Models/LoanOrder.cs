using System;

namespace Labb_1_Avancerat.NET.Models
{
    public class LoanOrder
    {
        public int LoanOrderId { get; set; }

        public DateTime DateOfLoan { get; set; }
        public DateTime DateOfReturn { get; set; }

        public DateTime OrderDate { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
