
namespace BookStoreManager.Persistence.Entities;

internal class AppUserEnity:UserEntity
{
    public string Login { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    
}