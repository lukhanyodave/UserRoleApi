using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uwc.Ics.Ws.WebApi.UserApi.Persistance
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            //var connectionString = configuration.GetConnectionString("DefaultConnection");

            //services.AddDbContext<ApplicationDbContext>(options =>
            //   options.UseSqlServer(connectionString,
            //       builder => builder.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));
            return services;
        }
    }
}
