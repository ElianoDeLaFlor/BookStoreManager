using BookStoreManager.Persistence.Entities;
using BookStoreManager.Persistence.RepositoriesInterfaces;
using Microsoft.EntityFrameworkCore;

namespace BookStoreManager.Persistence.DatabaseContext;

internal class DataContext(DbContextOptions<DataContext> options) : DbContext(options), IDataContext
{
    public DbSet<BookEntity> Books { get; set; }
    public DbSet<UserEntity> Users { get; set; }
    public DbSet<BookUserEntity> BookUsers { get; set; }
}
/*
*modelBuilder.Entity<Blog>().UseTpcMappingStrategy()
   .ToTable("Blogs");
modelBuilder.Entity<RssBlog>()
   .ToTable("RssBlogs");
*
*
*/