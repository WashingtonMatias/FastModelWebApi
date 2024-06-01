using Fiap.Application.Interfaces;
using Fiap.Application.Services;
using Fiap.Data.Context;
using Fiap.Data.Repositories;
using Fiap.Domain.Interfaces;
using Fiap.Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Fiap.Application.IoC
{
    public static class DependencyInjectionConfig
    {
        public static void AddResolveDependencies(this IServiceCollection services)
        {
            //Application
            services.AddScoped<IUsuarioApplicationServiceGenerico, UsuarioApplicationServiceGenerico>();
            services.AddScoped<IEnderecoApplicationServiceGenerico, EnderecoApplicationServiceGenerico>();
            services.AddScoped<IProdutoApplicationServiceGenerico, ProdutoApplicationServiceGenerico>();

            //Domain
            services.AddScoped(typeof(ICadastroServiceGenerico<>), typeof(CadastroServiceGenerico<>));
            services.AddScoped(typeof(ICadastroRepositoryGenerico<>), typeof(CadastroRepositoryGenerico<>));
            //Data
            services.AddScoped<FiapContext>();
            services.AddAutoMapper(typeof(MappingProfile));

        }
    }
}
