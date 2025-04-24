namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyContainer
{
    public static IServiceCollection AddNorthServices(this IServiceCollection services)
    {
        services.AddDebugWriter();
        services.AddServices();
        return services;
    }
}
