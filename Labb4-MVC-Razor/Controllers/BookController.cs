using Labb4_MVC_Razor.Models;
using Labb4_MVC_Razor.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb4_MVC_Razor.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IActionResult List()
        {
            var booksListViewModel = new BookListViewModel();
            booksListViewModel.Books = _bookRepository.GetBooks;

            return View(booksListViewModel);
        }

        public IActionResult Details(int id)
        {
            var bookListViewModel = new BookListViewModel();
            bookListViewModel.Book = _bookRepository.GetBookById(id);

            return View(bookListViewModel);
        }
    }
}
