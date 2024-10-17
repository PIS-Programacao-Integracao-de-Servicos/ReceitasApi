namespace Infrastructure.Configuration.Interfaces
{
    public interface ISecretsHelper
    {
        string GetConnectionString(string key);
    }
}
