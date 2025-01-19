using BookStoreManager.Application.IService;
using BookStoreManager.Domain.Models;

namespace BookStoreManager.Application.Service;

public class BookService:IBookService
{
    public async Task<Book> AddAsync(Book book, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task<Book> UpdateAsync(Book book, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task<Book> DeleteAsync(Guid bookId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task<Book> GetAsync(int bookId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Book>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}