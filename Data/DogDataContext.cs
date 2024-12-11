using FinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Data
{
    public class DogDataContext : DbContext
    {
        public DogDataContext(DbContextOptions<DogDataContext> options) : base(options) { }

    
        public DbSet<User> Users { get; set; }

        public DbSet<DogProfile> DogProfiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Map DogProfile to the DogInfo table
            modelBuilder.Entity<DogProfile>()
                .ToTable("DogInfo"); // Map to the existing "DogInfo" table

            // Optional: Specify the primary key (if it's not conventionally recognized)
            modelBuilder.Entity<DogProfile>()
                .HasKey(dp => dp.Id); // Assuming 'Id' is the primary key

            // Optional: Additional configurations for columns, constraints, etc.
            modelBuilder.Entity<DogProfile>()
                .Property(dp => dp.Name)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<DogProfile>()
                .Property(dp => dp.Description)
                .HasMaxLength(1000);
        }
    }
}
