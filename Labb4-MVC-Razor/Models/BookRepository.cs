using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb4_MVC_Razor.Models
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext _appDbContext;

        public BookRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Book> GetBooks { get => _appDbContext.Books; }

        public Book GetBookById(int id)
        {
            return _appDbContext.Books.FirstOrDefault(b => b.BookId == id);
        }
    }
}
