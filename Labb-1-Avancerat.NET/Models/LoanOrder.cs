using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Labb_1_Avancerat.NET.Models
{
    public class LoanOrder
    {
        [Key]
        public int LoanOrderId { get; set; }

        [DisplayFormat(DataFormatString = "{0:MMM-dd-yyyy}")]
        public DateTime DateOfLoan { get; set; }
        [DisplayFormat(DataFormatString = "{0:MMM-dd-yyyy}")]
        public DateTime DateOfReturn { get; set; }

        [Required]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        [Required]
        public int BookId { get; set; }
        public Book Book { get; set; }

    }
}
