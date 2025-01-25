using BookStoreManager.Domain.Models;
using BookStoreManager.Persistence.Entities;

namespace BookStoreManager.Persistence.RepositoriesInterfaces;

public interface IRepository<T> where T : class
{
    Task<ApiResponse<IEnumerable<T>?>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<ApiResponse<T?>> AddEnityAsync(T Entity, CancellationToken cancellationToken = default);
    Task<ApiResponse<T?>> UpdateAsync(T TEnity, CancellationToken cancellationToken = default);
    Task<ApiResponse<T?>> DeleteAsync(int entityId, CancellationToken cancellationToken = default);
    Task<ApiResponse<T?>> GetAsync(int entityId, CancellationToken cancellationToken = default);
}