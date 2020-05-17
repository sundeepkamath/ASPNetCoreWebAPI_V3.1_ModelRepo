using ASPNetCoreWebAPI.API.Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ASPNetCoreWebAPI.API.Persistence.Repositories
{
    public class BookRepository : IBookRepository
    {
        private IEnumerable<Book> _books = null;
        public BookRepository()
        {
            _books = new List<Book>
            {
                new Book()
                {
                    Id = 1,
                    Name = "Love in the time of Cholera",
                    Price = 50,
                    NumberOfPages = 1000,
                    PrintedLanguage = "Spanish",
                    FirstPublished = new DateTime(1995, 5, 2)
                },
                new Book()
                {
                    Id = 2,
                    Name = "A thousand splendid suns",
                    Price = 99.50F,
                    NumberOfPages= 600,
                    PrintedLanguage = "English",
                    FirstPublished = new DateTime(2001, 3, 15)
                },
                new Book()
                {
                    Id = 3,
                    Name = "The Godfather",
                    Price = 79.99F,
                    NumberOfPages = 450,
                    PrintedLanguage = "English",
                    FirstPublished = new DateTime(1983, 8, 6)
                }
            };
        }

        public IEnumerable<Book> GetBooks()
        {
            return _books;
        }

        public Book GetBook(int bookId)
        {
            Book book = _books.Where(b => b.Id == bookId).FirstOrDefault();

            return book;
        }
    }
}
