using BookStoreManager.Persistence.Entities;
using BookStoreManager.Persistence.RepositoriesInterfaces;
using Microsoft.EntityFrameworkCore;

namespace BookStoreManager.Persistence.DataContext;

internal class DataContext:DbContext, IDataContext
{
    public DbSet<BookEntity> Books { get; }
    public DbSet<UserEntity> Users { get; }
    public DbSet<BookUserEntity> BookUsers { get; }
}
/*
 *modelBuilder.Entity<Blog>().UseTpcMappingStrategy()
       .ToTable("Blogs");
   modelBuilder.Entity<RssBlog>()
       .ToTable("RssBlogs");
 *
 * 
 */