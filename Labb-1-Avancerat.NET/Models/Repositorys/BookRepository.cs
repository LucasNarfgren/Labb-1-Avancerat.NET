using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Labb_1_Avancerat.NET.Models
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext _context;

        public BookRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _context.Books.Include(b => b.Category);
        }

        public Book GetBookById(int id)
        {

            return _context.Books.Include(c => c.Category).FirstOrDefault(b => b.BookId == id);
        }


    }
}
