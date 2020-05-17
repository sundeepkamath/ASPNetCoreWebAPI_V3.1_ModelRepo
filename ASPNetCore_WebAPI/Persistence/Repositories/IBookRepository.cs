using ASPNetCoreWebAPI.API.Persistence.Entities;
using System.Collections.Generic;

namespace ASPNetCoreWebAPI.API.Persistence.Repositories
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetBooks();
        Book GetBook(int bookId);
    }
}
