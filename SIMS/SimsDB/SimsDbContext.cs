using Microsoft.EntityFrameworkCore;
using SIMS.SimsDB.Entities;

namespace SIMS.SimsDB
{
    public class SimsDbContext : DbContext
    {
        public SimsDbContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<User>().HasKey("Id");
            modelBuilder.Entity<User>().HasIndex(u => u.Username).IsUnique();
            modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();
            modelBuilder.Entity<User>().Property(u => u.Role).HasDefaultValue("Student");
            modelBuilder.Entity<User>().Property(u => u.Status).HasDefaultValue(0);
        }
    }
}
