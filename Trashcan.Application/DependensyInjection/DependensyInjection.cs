using Microsoft.Extensions.DependencyInjection;
using Trashcan.Application.Mapping;
using Trashcan.Application.Services;
using Trashcan.Domain.Interfaces.Services;

namespace Trashcan.Application.DependensyInjection;

public static class DependensyInjection
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddMappers();
    }

    private static void AddMappers(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(ActorMapping));
    }

    private static void InitServices(this IServiceCollection services)
    {
        services.AddScoped<IActorService, ActorService>();
    }
}