using JustSell.Data.Entities;
using JustSell.Data.Entities.Car;
using Microsoft.EntityFrameworkCore;

namespace JustSell.Data
{
    public class MainDBContext : DbContext
    {
        public MainDBContext() : base()
        {
        }

        public MainDBContext(DbContextOptions<MainDBContext> options) : base(options)
        {
        }

        public DbSet<LogEntry> LogEntries { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Engine> Engines { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasOne(x => x.Engine);
        }
    }
}
