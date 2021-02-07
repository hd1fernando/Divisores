using Divisores.Dominio.Interfaces;
using Divisores.Dominio.Notificacoes;
using Divisores.Dominio.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Divisores.Api.Configuracoes
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolverDependecias(this IServiceCollection services)
            => services
                .AddScoped<INotificador, Notificador>()
                .AddScoped<IDecomposicaoService, DecomposicaoService>();
    }
}
