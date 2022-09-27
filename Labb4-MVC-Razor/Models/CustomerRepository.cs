using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb4_MVC_Razor.Models
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext _appDbContext;

        public CustomerRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Customer> GetCustomers => _appDbContext.Customers;

        public Customer AddCustomer(Customer customer)
        {
            _appDbContext.Customers.Add(customer);
            _appDbContext.SaveChanges();

            return customer;
        }

        public void DeleteCustomer(Customer customer)
        {
            _appDbContext.Customers.Remove(customer);
            _appDbContext.SaveChanges();
        }

        public Customer GetCustomerById(int id)
        {
            return _appDbContext.Customers.FirstOrDefault(c => c.CustomerId == id);
        }

        public List<Book> GetCustomersBorrowedBooks(int id)
        {
            var borrowedBooks = new List<Book>();
            var result = from bookcustomers in _appDbContext.BookCustomers
                         join book in _appDbContext.Books on bookcustomers.BookId equals book.BookId
                         where bookcustomers.CustomerId == id
                         select book;

            foreach (var book in result)
            {
                borrowedBooks.Add(book);
            }

            return borrowedBooks;
        }

        public void UpdateCustomer(Customer customer)
        {
            var result = _appDbContext.Customers.FirstOrDefault(c => c.CustomerId == customer.CustomerId);

            if (result != null)
            {
                result.CustomerName = customer.CustomerName;
                result.CustomerEmail = customer.CustomerEmail;
                result.CustomerPhone = customer.CustomerPhone;

                _appDbContext.SaveChanges();
            }
        }
    }
}
