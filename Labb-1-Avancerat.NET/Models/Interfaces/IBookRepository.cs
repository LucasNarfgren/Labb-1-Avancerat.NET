using System.Collections.Generic;

namespace Labb_1_Avancerat.NET.Models
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAllBooks();
        Book GetBookById(int id);
    }
}
