using LG.ApiNetCore6.Application.Mappings;
using LG.ApiNetCore6.Application.Services;
using LG.ApiNetCore6.Application.Services.Interface;
using LG.ApiNetCore6.Domain.Repositories;
using LG.ApiNetCore6.Infra.Data.Context;
using LG.ApiNetCore6.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG.ApiNetCore6.Infra.IoC
{
    public static class DependencyInjection
    {
        //injetar nosso serviços banco e repositorio
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            //injetor do nosso banco 
             services.AddDbContext<ApplicationDbContext>(options => 
                                                         options.UseNpgsql(configuration.GetConnectionString("")));

            services.AddScoped<IPessoaRepository, PessoaRepository>();
            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            //injetor do nosso mapper e serviços
            services.AddAutoMapper(typeof(DomainToDtoMapping));
            services.AddScoped<IPessoaService, PessoaService>();
            return services;
        }


    }
}
