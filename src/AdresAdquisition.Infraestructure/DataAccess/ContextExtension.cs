using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AdresAdquisition.Infraestructure.DataAccess
{
    public static class ContextExtension
    {
        public static IServiceCollection AddContextExtension(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddDbContext<AdresContext>(
                                        options => options.UseSqlServer(
                                        configuration.GetConnectionString("DBAdres"),
                                        providerOptions => providerOptions.EnableRetryOnFailure()));
            return services;
        }
    }
}
