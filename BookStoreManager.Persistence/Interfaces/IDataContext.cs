using BookStoreManager.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookStoreManager.Persistence.RepositoriesInterfaces;

public interface IDataContext
{
    DbSet<BookEntity> Books { get; set; }
    DbSet<UserEntity> Users { get; set; }
    DbSet<BookUserEntity> BookUsers { get; set; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}