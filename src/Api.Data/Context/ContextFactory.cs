using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            var connectionString = "Server=localhost;Port=3306;Database=DDD;Uid=root;Pwd=h1122330";
            var optionBuilder = new DbContextOptionsBuilder<MyContext>();

            optionBuilder.UseMySQL(connectionString);
            return new MyContext(optionBuilder.Options);
        }
    }
}
