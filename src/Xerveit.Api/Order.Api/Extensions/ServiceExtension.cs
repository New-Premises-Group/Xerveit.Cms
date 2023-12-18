using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace Order.Api.Extensions;
public static class ServicesExtension
{
    public static void AddDIServices(this IServiceCollection services)
    {
        services.AddCors();
        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer();

        //Config options for services
        services.ConfigureOptions<JwtOptionSetup>();
        services.ConfigureOptions<RabbitMqOptionSetup>();
        services.ConfigureOptions<JwtBearerOptionsSetup>();
        services.AddAuthorization();
    }
}