using BookStoreManager.Domain.Models;

namespace BookStoreManager.Application.IService;

public interface IBookService
{
    Task<ApiResponse<Book>> AddAsync(Book book, CancellationToken cancellationToken = default);
    Task<ApiResponse<Book>> UpdateAsync(Book book, CancellationToken cancellationToken = default);
    Task<ApiResponse<Book>> DeleteAsync(Guid bookId, CancellationToken cancellationToken = default);
    Task<ApiResponse<Book>> GetAsync(int bookId, CancellationToken cancellationToken = default);
    Task<ApiResponse<IEnumerable<Book>>> GetAllAsync(CancellationToken cancellationToken = default);
}