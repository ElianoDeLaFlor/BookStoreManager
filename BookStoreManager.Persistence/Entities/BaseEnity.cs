namespace BookStoreManager.Persistence.Entities;

public class BaseEnity
{
    public int Id { get; set; }
    public DateTime LastUpdate { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreateDate { get; set; }
}