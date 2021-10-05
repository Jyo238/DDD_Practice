using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System.IO;

namespace Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        private readonly IConfigurationRoot configuration;
        public ContextFactory(IConfigurationRoot _configuration)
        {
            configuration = _configuration;
        }

        public MyContext CreateDbContext(string[] args)
        {
            // Find a way to get different connection string 
            var connectionString = configuration.GetConnectionString("Default");

            //var connectionString = "Server=localhost;Port=3306;Database=DDD;Uid=root;Pwd=h1122330";
            var optionBuilder = new DbContextOptionsBuilder<MyContext>();

            optionBuilder.UseMySQL(connectionString);
            return new MyContext(optionBuilder.Options);
        }
    }
}
