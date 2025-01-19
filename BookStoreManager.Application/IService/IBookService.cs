using BookStoreManager.Domain.Models;

namespace BookStoreManager.Application.IService;

public interface IBookService
{
    Task<Book> AddAsync(Book book, CancellationToken cancellationToken = default);
    Task<Book> UpdateAsync(Book book, CancellationToken cancellationToken = default);
    Task<Book> DeleteAsync(Guid bookId, CancellationToken cancellationToken = default);
    Task<Book> GetAsync(int bookId, CancellationToken cancellationToken = default);
    Task<IEnumerable<Book>> GetAllAsync(CancellationToken cancellationToken = default);
}