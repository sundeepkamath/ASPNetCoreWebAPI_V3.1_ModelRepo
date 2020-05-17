using ASPNetCoreWebAPI.API.Core.Repositories;
using ASPNetCoreWebAPI.API.Persistence.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ASPNetCoreWebAPI.API.Controllers
{
    [ApiController]
    public class BooksController : ControllerBase
    {
        private IBookRepository _bookRepository;

        public BooksController(IBookRepository bookRespository)
        {
            _bookRepository = bookRespository;
        }

        [HttpGet("api/books")]
        public IActionResult GetBooks()
        {
            IEnumerable<Book> books = _bookRepository.GetBooks();

            return new JsonResult(books);
        }
    }
}
