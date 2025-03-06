using ChamadoPro.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ChamadoPro.Infrastructure.Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        { }

        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);
        }
    }
}
