using CrudMoura.Business.Interfaces;
using CrudMoura.Business.Notifications;
using CrudMoura.Business.Services;
using CrudMoura.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace CrudMoura.Api.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<ITarefaRepository, TarefaRepository>();
            
            services.AddScoped<INotificador, Notificador>();

            services.AddScoped<ITarefaService, TarefaService>();

            return services;
        }
    }
}
