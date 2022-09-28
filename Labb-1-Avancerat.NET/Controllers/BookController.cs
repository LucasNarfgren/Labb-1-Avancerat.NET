using Labb_1_Avancerat.NET.Models;
using Labb_1_Avancerat.NET.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Labb_1_Avancerat.NET.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepo;

        public BookController(IBookRepository bookRepo)
        {
            _bookRepo = bookRepo;
        }

        public IActionResult Index()
        {
            var books = _bookRepo.GetAllBooks();

            return View(books);
        }

        [HttpGet("Book/{id}")]
        public IActionResult Book(int id)
        {
            var book = _bookRepo.GetBookById(id);
            return View(book);
        }

    }
}
