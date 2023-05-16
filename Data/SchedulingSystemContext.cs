using Microsoft.EntityFrameworkCore;
using SchedulingSystem.Data.Mapping;
using SchedulingSystem.Models;

namespace SchedulingSystem.Data
{
    public class SchedulingSystemContext : DbContext
    {

        public DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=localhost,1433;Database=DbSchedulingSystem;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=true");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
        }
    }
}