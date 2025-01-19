using BookStoreManager.Persistence.Entities;
using BookStoreManager.Persistence.RepositoriesInterfaces;

namespace BookStoreManager.Persistence.Repositories;

internal class BookRepository:IBookRepository
{
    public async Task<IEnumerable<BookEntity>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task AddAsync(BookEntity book, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task UpdateAsync(BookEntity book, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteAsync(Guid bookId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task<BookEntity?> GetAsync(int bookId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}