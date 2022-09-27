using Labb4_MVC_Razor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb4_MVC_Razor.ViewModels
{
    public class BorrowedBooksViewModel
    {
        public Customer Customer { get; set; }
        public List<Book> BorrowedBooks { get; set; }
        public BookCustomer BookCustomer { get; set; }
    }
}
