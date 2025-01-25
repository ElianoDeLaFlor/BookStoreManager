using BookStoreManager.Application.IService;
using BookStoreManager.Domain.Models;

namespace BookStoreManager.Application.Service;

public class BookService:IBookService
{
    public async Task<ApiResponse<Book>> AddAsync(Book book, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task<ApiResponse<Book>> UpdateAsync(Book book, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task<ApiResponse<Book>> DeleteAsync(int entityId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task<ApiResponse<Book>> GetAsync(int bookId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task<ApiResponse<IEnumerable<Book>>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}