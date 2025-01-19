using AutoMapper;
using BookStoreManager.Domain.Models;
using BookStoreManager.Persistence.Entities;

namespace BookStoreManager.Persistence.Dtos;

public class EntityMapperProfile: Profile
{
    public EntityMapperProfile()
    {
        CreateMap<Book, BookEntity>();
        CreateMap<BookEntity, Book>();}
}