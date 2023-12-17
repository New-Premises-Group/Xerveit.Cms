using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;

namespace Core.Configurations
{
    public class RabbitMqOptionSetup : IConfigureOptions<RabbitMqOptions>
    {
        private const string SectionName = "RabbitMq";

        private readonly IConfiguration _configuration;

        public RabbitMqOptionSetup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void Configure(RabbitMqOptions options)
        {
            _configuration.GetSection(SectionName).Bind(options);
        }
    }
}