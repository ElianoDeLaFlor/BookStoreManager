namespace BookStoreManager.Domain.Models;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public string ISBN { get; set; }
}