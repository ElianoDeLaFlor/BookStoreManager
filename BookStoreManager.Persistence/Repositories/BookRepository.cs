using AutoMapper;
using BookStoreManager.Domain.Models;
using BookStoreManager.Persistence.Entities;
using BookStoreManager.Persistence.RepositoriesInterfaces;
using Microsoft.EntityFrameworkCore;

namespace BookStoreManager.Persistence.Repositories;

internal class BookRepository(IDataContext dataContext, IMapper mapper) : IBookRepository
{
    public async Task<ApiResponse<IEnumerable<Book>?>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        var response = new ApiResponse<IEnumerable<Book>?>();
        try
        {
            var books = await dataContext.Books.ToListAsync(cancellationToken);
            var result = mapper.Map<IEnumerable<Book>>(books);
            response.Data = result;
            response.Message="Success";
            response.Success = true;
        }
        catch (Exception e)
        {
            response.Data = null;
            response.Message = e.Message;
            response.Success = false;
        }
        return response;
    }

    public async Task<ApiResponse<Book?>> AddEnityAsync(Book book, CancellationToken cancellationToken = default)
    {
        var response = new ApiResponse<Book?>();
        try
        {
            var bookEntity = mapper.Map<BookEntity>(book);
            var result = await dataContext.Books.AddAsync(bookEntity, cancellationToken);
            _= await dataContext.SaveChangesAsync(cancellationToken);
            var resultBook = mapper.Map<Book>(result.Entity);
            response.Data = resultBook;
            response.Message = "Success";
            response.Success = true;
        }
        catch (Exception e)
        {
            response.Data = null;
            response.Message = e.Message;
            response.Success = false;
        }
        return response;
    }

    public async Task<ApiResponse<Book?>> UpdateAsync(Book tenity, CancellationToken cancellationToken = default)
    {
        var response = new ApiResponse<Book?>();
        try
        {
            var book =
                await (from item in dataContext.Books where item.Id == tenity.Id select item).SingleAsync(cancellationToken);
            dataContext.Books.Update(book);
            _= await dataContext.SaveChangesAsync(cancellationToken);
            
            var result = mapper.Map<Book?>(book);
            response.Data = result;
            response.Message="Success";
            response.Success = true;
        }
        catch (Exception e)
        {
            response.Data = null;
            response.Message = e.Message;
            response.Success = false;
        }
        return response;
    }

    public async Task<ApiResponse<Book?>> DeleteAsync(int entityId, CancellationToken cancellationToken = default)
    {
        var response = new ApiResponse<Book?>();
        try
        {
            var book =
                await (from item in dataContext.Books where item.Id == entityId select item).SingleAsync(cancellationToken);
            dataContext.Books.Remove(book);
            _= await dataContext.SaveChangesAsync(cancellationToken);
            var result = mapper.Map<Book>(book);
            response.Data = result;
            response.Message="Success";
            response.Success = true;
        }
        catch (Exception e)
        {
            response.Data = null;
            response.Message = e.Message;
            response.Success = false;
        }
        return response;
    }
    public async Task<ApiResponse<Book?>> GetAsync(int bookId, CancellationToken cancellationToken = default)
    {
        var response = new ApiResponse<Book?>();
        try
        {
            var book =
                await (from item in dataContext.Books where item.Id == bookId select item).SingleAsync(cancellationToken);
            var result = mapper.Map<Book?>(book);
            response.Data = result;
            response.Message="Success";
            response.Success = true;
        }
        catch (Exception e)
        {
            response.Data = null;
            response.Message = e.Message;
            response.Success = false;
        }
        return response;
    }
}