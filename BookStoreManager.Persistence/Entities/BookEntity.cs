namespace BookStoreManager.Persistence.Entities;

public class BookEntity:BaseEnity
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public string ISBN { get; set; }
}