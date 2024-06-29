using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace AdresAcquisition.Aplication
{
    public static class MediatrExtension
    {
        public static IServiceCollection AddMediatorExtension(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            return services;
        }
    }
}
