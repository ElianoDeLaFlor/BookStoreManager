using AutoMapper;
using BookStoreManager.Domain.Models;
using BookStoreManager.Persistence.Entities;
using BookStoreManager.Persistence.RepositoriesInterfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace BookStoreManager.Persistence.Repositories;

internal class BookRepository:IBookRepository
{
    private readonly IDataContext _dataContext;
    private readonly IMapper _mapper;
    public BookRepository(IDataContext dataContext, IMapper mapper)
    {
        _dataContext=dataContext;
        _mapper=mapper;
    }
    public async Task<ApiResponse<IEnumerable<Book>?>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        var response = new ApiResponse<IEnumerable<Book>?>();
        try
        {
            var books = await _dataContext.Books.ToListAsync(cancellationToken);
            var result = _mapper.Map<IEnumerable<Book>>(books);
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
            var bookEntity = _mapper.Map<BookEntity>(book);
            var result = await _dataContext.Books.AddAsync(bookEntity, cancellationToken);
            _= await _dataContext.SaveChangesAsync(cancellationToken);
            var resultBook = _mapper.Map<Book>(result.Entity);
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

    public async Task<ApiResponse<Book>> UpdateAsync(Book TEnity, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task<ApiResponse<Book>> DeleteAsync(int entityId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
    public async Task<ApiResponse<Book?>> GetAsync(int bookId, CancellationToken cancellationToken = default)
    {
        var response = new ApiResponse<Book?>();
        try
        {
            var book =
                await (from item in _dataContext.Books where item.Id == bookId select item).SingleAsync(cancellationToken);
            var result = _mapper.Map<Book?>(book);
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