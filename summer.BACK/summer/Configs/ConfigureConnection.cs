using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using summer.Core.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace summer.API.Configs
{
    public static class ConfigureConnection
    {
        public static IServiceCollection AddConnectionProvider(
            this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddDbContext<TasksContext>(opt => opt.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly("summer.API"))
            );
            return services;
        }
    }
}
