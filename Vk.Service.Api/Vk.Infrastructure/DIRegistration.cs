using Microsoft.Extensions.DependencyInjection;

namespace Vk.Infrastructure;

public static class DIRegistration
{
    /// <summary>Регистрация в DI интерфейсов</summary>
    /// <param name="services">Коллекция сервисов</param>
    /// <returns>Коллекция сервисов с зарегистрированными интерфейсами</returns>
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        //services.AddScoped<IUserRepository, UserReposutory>();

        return services;
    }

    public static IServiceCollection AddConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddNamedOption<UWSServiceOption>()
    }
}
