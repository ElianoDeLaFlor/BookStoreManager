using BookStoreManager.Domain.Models;
using BookStoreManager.Persistence.Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace BookStoreManager.Persistence.RepositoriesInterfaces;

internal interface IBookRepository
{
    Task<ApiResponse<IEnumerable<Book>?>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<ApiResponse<Book?>> AddEnityAsync(Book book, CancellationToken cancellationToken = default);
    Task<ApiResponse<Book>> UpdateAsync(BookEntity book, CancellationToken cancellationToken = default);
    Task<ApiResponse<Book>> DeleteAsync(Guid bookId, CancellationToken cancellationToken = default);
    Task<ApiResponse<Book>> GetAsync(int bookId, CancellationToken cancellationToken = default);
}