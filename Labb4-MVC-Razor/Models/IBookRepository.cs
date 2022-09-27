using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb4_MVC_Razor.Models
{
    public interface IBookRepository
    {
        public IEnumerable<Book> GetBooks { get; }
        public Book GetBookById(int id);
    }
}
