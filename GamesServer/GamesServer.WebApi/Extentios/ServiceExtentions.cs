using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper.Configuration;
using GamesServer.DAL.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace GamesServer.WebApi.Extentios
{
    public static class ServiceExtentions
    {
        public static void ConfigureSqlServer(this IServiceCollection services,string connection)
        {
            services.AddDbContext<ApplicationContext>(options =>
            {
                options.UseSqlServer(connection,b=> b.MigrationsAssembly("GamesServer.DAL"));

            });
        }
    }
}
