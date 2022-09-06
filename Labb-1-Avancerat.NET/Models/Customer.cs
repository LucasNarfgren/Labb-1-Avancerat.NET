using System.Collections.Generic;

namespace Labb_1_Avancerat.NET.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public List<Book> Books { get; set; }
    }
}
