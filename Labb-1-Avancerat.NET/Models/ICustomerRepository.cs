using System.Collections.Generic;

namespace Labb_1_Avancerat.NET.Models
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAllCustomers();
        Customer GetCustomer(int id);
    }
}
