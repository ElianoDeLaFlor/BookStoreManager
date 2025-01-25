using BookStoreManager.Domain.Models;

namespace BookStoreManager.Application.IService;

public interface IService<T> where T:class
{
    Task<ApiResponse<T>> AddAsync(T entity, CancellationToken cancellationToken = default);
    Task<ApiResponse<T>> UpdateAsync(T entity, CancellationToken cancellationToken = default);
    Task<ApiResponse<T>> DeleteAsync(int entityId, CancellationToken cancellationToken = default);
    Task<ApiResponse<T>> GetAsync(int entityId, CancellationToken cancellationToken = default);
    Task<ApiResponse<IEnumerable<T>>> GetAllAsync(CancellationToken cancellationToken = default);
}