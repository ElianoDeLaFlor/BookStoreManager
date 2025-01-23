namespace BookStoreManager.Domain.Models;

public class DbConfigOptions
{
    public string ConnectionString { get; init; } = string.Empty;
    public string Provider { get; init; } = "SqlServer";  // Default provider
}