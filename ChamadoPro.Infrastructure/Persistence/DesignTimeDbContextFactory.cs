using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace ChamadoPro.Infrastructure.Persistence
{
    internal class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        public DataContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-C06PPRP;Initial Catalog=ChamadoPro;Integrated Security=True;Trust Server Certificate=True");

            return new DataContext(optionsBuilder.Options);
        }
    }
}
