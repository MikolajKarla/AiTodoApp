using AiTodo.infrastructure.Persistance;
using AiTodo.infrastructure.Seeders;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiTodo.infrastructure.Extensions
{
    public static class ServiceCollections
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<aitodoDBContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("AiTodo"),
                    b => b.MigrationsAssembly("AiTodo.infrastructure"))); // Add this line
            services.AddScoped<ExTodo>();
        }
    }
}
