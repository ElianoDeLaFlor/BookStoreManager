using BookStoreManager.Domain.Models;
using BookStoreManager.Persistence.Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace BookStoreManager.Persistence.RepositoriesInterfaces;

internal interface IBookRepository:IRepository<Book>
{ }