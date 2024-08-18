using Microsoft.Extensions.DependencyInjection;
using PrometheusGrafanaDotnetCore.Application.Services;

namespace PrometheusGrafanaDotnetCore.Application;

public static class ApplicationServiceConfigurator
{
    public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services)
    {
        services.AddTransient<UserService>();
        return services;
    }
}
