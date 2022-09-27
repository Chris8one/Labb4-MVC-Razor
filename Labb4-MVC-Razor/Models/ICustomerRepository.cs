using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb4_MVC_Razor.Models
{
    public interface ICustomerRepository
    {
        public IEnumerable<Customer> GetCustomers { get; }
        public Customer GetCustomerById(int id);
        public Customer AddCustomer(Customer newCustomer);
        public void DeleteCustomer(Customer deleteCustomer);
        public void UpdateCustomer(Customer updateCustomer);
        public List<Book> GetCustomersBorrowedBooks(int id);
    }
}
