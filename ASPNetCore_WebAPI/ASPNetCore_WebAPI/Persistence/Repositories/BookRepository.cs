using ASPNetCoreWebAPI.API.Core.Repositories;
using ASPNetCoreWebAPI.API.Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNetCoreWebAPI.API.Persistence.Repositories
{
    public class BookRepository : IBookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            IEnumerable<Book> books = new List<Book>
            {
                new Book()
                {
                    Id = 1,
                    Name = "Love in the time of Cholera",
                    Price = 50,
                    NumberOfPages = 1000,
                    PrintedLanguage = "Spanish"
                },
                new Book()
                {
                    Id = 2,
                    Name = "A thousand splendid suns",
                    Price = 99.50F,
                    NumberOfPages= 600,
                    PrintedLanguage = "English"
                },
                new Book()
                {
                    Id = 3,
                    Name = "The Godfather",
                    Price = 79.99F,
                    NumberOfPages = 450,
                    PrintedLanguage = "English"
                }
            };

            return books;
        }
    }
}
