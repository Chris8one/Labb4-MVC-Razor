using Labb4_MVC_Razor.Models;
using Labb4_MVC_Razor.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb4_MVC_Razor.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public IActionResult List()
        {
            var customerListViewModel = new CustomerListViewModel();
            customerListViewModel.Customers = _customerRepository.GetCustomers;

            if (customerListViewModel == null)
            {
                return NotFound();
            }

            return View(customerListViewModel);
        }

        // Add a new customer to db
        public IActionResult AddACustomer()
        {
            var newCustomer = new CustomerViewModel();

            return View(newCustomer);
        }

        public IActionResult AddNewCustomer(CustomerViewModel newCustomer)
        {
            _customerRepository.AddCustomer(newCustomer.CustomerVm);

            return RedirectToAction(nameof(List));
        }

        // Delete a customer from db
        public IActionResult DeleteACustomer()
        {
            var deleteCustomer = new CustomerViewModel();
            deleteCustomer.Customers = _customerRepository.GetCustomers;

            return View(deleteCustomer);
        }

        public IActionResult DeleteCustomer(CustomerViewModel deleteCustomer)
        {
            var customers = _customerRepository.GetCustomers;
            _customerRepository.DeleteCustomer(customers.FirstOrDefault(c => c.CustomerName == deleteCustomer.CustomerVm.CustomerName));

            return RedirectToAction(nameof(List));
        }

        // Update a customer in db
        public IActionResult UpdateACustomer()
        {
            var updateCustomer = new CustomerViewModel();
            updateCustomer.Customers = _customerRepository.GetCustomers;

            return View(updateCustomer);
        }

        public IActionResult UpdateCustomer(CustomerViewModel updateCustomer)
        {
            _customerRepository.UpdateCustomer(updateCustomer.CustomerVm);

            return RedirectToAction(nameof(List));
        }

        // List of the customers borrowed books
        public IActionResult BorrowedBooks(int id)
        {
            var borrowedBooks = new BorrowedBooksViewModel();
            borrowedBooks.Customer = _customerRepository.GetCustomerById(id);
            borrowedBooks.BorrowedBooks = _customerRepository.GetCustomersBorrowedBooks(id);

            if (borrowedBooks == null)
            {
                return NotFound();
            }

            return View(borrowedBooks);
        }
    }
}
