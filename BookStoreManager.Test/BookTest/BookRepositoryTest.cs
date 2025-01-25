using AutoMapper;
using BookStoreManager.Persistence.DatabaseContext;
using BookStoreManager.Persistence.Dtos;
using BookStoreManager.Persistence.Entities;
using BookStoreManager.Persistence.Repositories;
using BookStoreManager.Persistence.RepositoriesInterfaces;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;
using Assert = Xunit.Assert;

namespace BookStoreManager.Test.BookTest;

public class BookRepositoryTest
{
    private readonly BookRepository _bookRepository;
    private readonly IDataContext _dataContext;
    private readonly IMapper _mapper;

    public BookRepositoryTest()
    {
        // Configure in-memory database
        var options = new DbContextOptionsBuilder<DataContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase") // Unique name to avoid collisions
            .Options;

        _dataContext = new DataContext(options);
        
        // Seed initial data for tests
        _dataContext.Books.AddRange(
            new BookEntity { Id = 1, Author = "auteur1", Title = "Titre1",Description = "Description1",Price = 10,CreateDate = DateTime.Now,IsDeleted = false,ISBN = "ISBN1",LastUpdate = DateTime.Now },
            new BookEntity { Id = 2, Author = "auteur2", Title = "Titre2" ,Description = "Description2",Price = 20,CreateDate = DateTime.Now,IsDeleted = false,ISBN = "ISBN2",LastUpdate = DateTime.Now },
            new BookEntity {Id = 3, Author = "auteur3", Title = "Titre3" ,Description = "Description3",Price = 30,CreateDate = DateTime.Now,IsDeleted = false,ISBN = "ISBN3",LastUpdate = DateTime.Now },
            new BookEntity {Id = 4, Author = "auteur4", Title = "Titre4" ,Description = "Description4",Price = 40,CreateDate = DateTime.Now,IsDeleted = false,ISBN = "ISBN4",LastUpdate = DateTime.Now },
            new BookEntity {Id = 5, Author = "auteur5", Title = "Titre5" ,Description = "Description5",Price = 50,CreateDate = DateTime.Now,IsDeleted = false,ISBN = "ISBN5",LastUpdate = DateTime.Now }
        );
        
         //Configure AutoMapper
        var mapperConfiguration = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile<EntityMapperProfile>();
        });
        _mapper=mapperConfiguration.CreateMapper();
        _=_dataContext.SaveChangesAsync();

        _bookRepository = new BookRepository(_dataContext,_mapper);
    }

    [Fact]
    public async Task GetBookById_ShouldReturnBook()
    {
        // Act
        var result = await _bookRepository.GetAsync(1);

        // Assert
        Assert.NotNull(result);
        Assert.True(result.Success);
        Assert.Equal("Success", result.Message);
        Assert.Equal(1, result.Data?.Id);
        Assert.Equal("auteur1", result.Data?.Author);
        Assert.Equal("Titre1", result.Data?.Title);
    }
    
    [Fact]
    public async Task GetBookById_ShouldReturnNull()
    {
        // Act
        var result = await _bookRepository.GetAsync(10);
        // Assert
        Assert.NotNull(result);
        Assert.False(result.Success);
        Assert.Null(result.Data);
    }
    
    [Fact]
    public async Task DeleteBook_ShouldDeleteBook()
    {
        // Act
        var result = await _bookRepository.DeleteAsync(2);
        
        var result2 = await _bookRepository.GetAllAsync();
        // Assert
        Assert.NotNull(result);
        Assert.True(result.Success);
        Assert.Equal(result2.Data?.Count(), 4);
    }
    
    [Fact]
    public async Task GetAllBook_ShouldReturnAllBook()
    {
        // Act
        var result = await _bookRepository.GetAllAsync();
        // Assert
        Assert.NotNull(result);
        Assert.True(result.Success);
        Assert.Equal(result.Data?.Count(), 4);
    }
    
    
}