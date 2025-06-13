using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EasyTable.Data
{
    public class EasyTableDbContextFactory : IDesignTimeDbContextFactory<EasyTableDbContext>
    {
        public EasyTableDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<EasyTableDbContext>();
            optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=RestaurantAppDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

            return new EasyTableDbContext(optionsBuilder.Options);
        }
    }
}