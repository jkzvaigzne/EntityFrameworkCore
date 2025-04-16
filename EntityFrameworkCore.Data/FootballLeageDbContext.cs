using EntityFrameworkCore.Domain;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCore.Data
{
    public class FootballLeageDbContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }
        public DbSet<Coach> Coaches { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Using SQL Server
            //optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FootballLeage_EfCore; Encrypt=False");
            
            optionsBuilder.UseSqlite($"Data Source=FootballLeage_EfCore.db");
        }
    }
}
