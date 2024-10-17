using Infrastructure.Configuration.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Configuration
{
    public class SecretsHelper : ISecretsHelper
    {
        private readonly IConfiguration _configuration;

        public SecretsHelper(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        public string GetConnectionString(string key)
        {
            return _configuration.GetConnectionString(key);
        }
    }
}
