using Data.Context;
using Data.Repository;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;

namespace CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepository<>),typeof(BaseRepository<>));
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

            // Find a way to get different connection string 
            var connectionString = configuration.GetConnectionString("Default");
            var serverVersion = ServerVersion.AutoDetect(connectionString);
            serviceCollection.AddDbContext<MyContext>(options => options.UseMySql(connectionString, serverVersion));
        }
    }
}
