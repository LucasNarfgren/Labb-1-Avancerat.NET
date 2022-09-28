using Labb_1_Avancerat.NET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb_1_Avancerat.NET.ViewModel
{
    public class LendViewModel
    {
        public Book Book { get; set; }
        public Customer Customer { get; set; }
        public IEnumerable<Customer> Customers { get; set; }
        public IEnumerable<Book> Books { get; set; }
        
    }
}
