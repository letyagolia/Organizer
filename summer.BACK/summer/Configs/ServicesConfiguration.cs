using Microsoft.Extensions.DependencyInjection;
using summer.Core.Repositories;
using summer.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace summer.API.Configs
{
    public static class ServicesConfiguration
    {
         public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services
                .AddTransient<ICategoryRepository, CategoryRepository>()
                .AddTransient<IFolderRepository, FolderRepository>()
                .AddTransient<INoteRepository, NoteRepository>();
                
                
            return services;
        }
        public static IServiceCollection AddCorsConfiguration(this IServiceCollection services) =>
        services.AddCors(options =>
        {
            options.AddPolicy("AllowAll", new Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicyBuilder()
           .AllowAnyHeader()
           .AllowAnyMethod()
           .AllowAnyOrigin()
          .AllowCredentials()
          .Build());
        });

    }
}
