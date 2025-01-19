namespace BookStoreManager.Domain.Models;

public class AppUser: User
{
    public string Login { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
}