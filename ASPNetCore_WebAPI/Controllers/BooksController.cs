using ASPNetCoreWebAPI.API.Models;
using ASPNetCoreWebAPI.API.Persistence.Entities;
using ASPNetCoreWebAPI.API.Persistence.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ASPNetCoreWebAPI.API.Controllers
{
    [ApiController]
    [Route("api/books")]
    public class BooksController : ControllerBase
    {
        private IBookRepository _bookRepository;
        private IMapper _mapper;

        public BooksController(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository ?? throw new ArgumentNullException(nameof(bookRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));

        }

        [HttpGet()]
        public ActionResult<IEnumerable<BookDto>> GetBooks()
        {
            var booksFromRepo = _bookRepository.GetBooks();
           
            return Ok(_mapper.Map<IEnumerable<BookDto>>(booksFromRepo));
        }

        [HttpGet("{bookId}")]
        public ActionResult<BookDto> GetBook(int bookId)
        {
            var bookFromRepo = _bookRepository.GetBook(bookId);

            if (bookFromRepo == null)
                return NotFound();

            return Ok(_mapper.Map<BookDto>(bookFromRepo));
        }
    }
}
