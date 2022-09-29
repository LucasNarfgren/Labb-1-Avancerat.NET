using Labb_1_Avancerat.NET.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb_1_Avancerat.NET.Components
{
    public class Books : ViewComponent
    {
        private readonly IBookRepository _bookRepo;

        public Books(IBookRepository bookRepo)
        {
            _bookRepo = bookRepo;
        }

        public IViewComponentResult Invoke()
        {
            var books = _bookRepo.GetAllBooks().OrderBy(b => b.BookId);
            return View(books);
        }
    }
}
