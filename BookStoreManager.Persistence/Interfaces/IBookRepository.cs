using BookStoreManager.Persistence.Entities;

namespace BookStoreManager.Persistence.RepositoriesInterfaces;

internal interface IBookRepository
{
    Task<IEnumerable<BookEntity>> GetAllAsync(CancellationToken cancellationToken = default);
    Task AddAsync(BookEntity book, CancellationToken cancellationToken = default);
    Task UpdateAsync(BookEntity book, CancellationToken cancellationToken = default);
    Task DeleteAsync(Guid bookId, CancellationToken cancellationToken = default);
    Task<BookEntity?> GetAsync(int bookId, CancellationToken cancellationToken = default);
}