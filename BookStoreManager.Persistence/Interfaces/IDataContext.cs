using BookStoreManager.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookStoreManager.Persistence.RepositoriesInterfaces;

interface IDataContext
{
    DbSet<BookEntity> Books { get; }
    DbSet<UserEntity> Users { get; }
    DbSet<BookUserEntity> BookUsers { get; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}