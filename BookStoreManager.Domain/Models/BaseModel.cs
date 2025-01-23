namespace BookStoreManager.Domain.Models;

public class BaseModel
{
    public int Id { get; set; }
    public DateTime LastUpdate { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreateDate { get; set; }
}