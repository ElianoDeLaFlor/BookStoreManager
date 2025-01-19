namespace BookStoreManager.Persistence.Entities;

internal class BookEntity
{
    private int Id { get; set; }
    private string Title { get; set; }
    private string Author { get; set; }
    private string Description { get; set; }
    private int Price { get; set; }
    private string ISBN { get; set; }
}