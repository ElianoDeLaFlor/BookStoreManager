namespace BookStoreManager.Domain.Models;

public class Book: BaseModel
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public string ISBN { get; set; }
}