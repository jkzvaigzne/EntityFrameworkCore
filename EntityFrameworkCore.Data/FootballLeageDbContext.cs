using EntityFrameworkCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EntityFrameworkCore.Data
{
    public class FootballLeageDbContext : DbContext
    {
        public FootballLeageDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Combine(path, "FootballLeage_EfCore.db");
        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Coach> Coaches { get; set; }
        public string DbPath { get; private set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Using SQL Server
            //optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FootballLeage_EfCore; Encrypt=False");
            
            optionsBuilder.UseSqlite($"Data Source={DbPath}")
                .LogTo(Console.WriteLine, LogLevel.Information)
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().HasData(
                new Team
                {
                    TeamId = 1,
                    Name = "Team A FC",
                    CreatedDate = new DateTime(2025, 04, 17)
                }, 
                new Team
                {
                    TeamId = 2,
                    Name = "Team B FC",
                    CreatedDate = new DateTime(2025, 04, 17)
                },
                new Team
                {
                    TeamId = 3,
                    Name = "Team C FC",
                    CreatedDate = new DateTime(2025, 04, 17),
                }
            );
        }
    }
}
