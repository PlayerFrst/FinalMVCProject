using FinalMVCProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FinalMVCProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder); 
            
            builder.Entity<Car>() 
                .HasOne(c => c.Category) 
                .WithMany(cat => cat.Cars) 
                .HasForeignKey(c => c.CategoryId) 
                .OnDelete(DeleteBehavior.Restrict); 
            
            builder.Entity<Car>() 
                .HasOne(c => c.Owner) 
                .WithMany(u => u.Cars) 
                .HasForeignKey(c => c.OwnerId) 
                .OnDelete(DeleteBehavior.Restrict); 
            
            builder.Entity<Car>() 
                .HasOne(c => c.Manufacturer) 
                .WithMany(m => m.Cars) 
                .HasForeignKey(c => c.ManufacturerId) 
                .OnDelete(DeleteBehavior.SetNull); 
            
            builder.Entity<Review>() 
                .HasOne(r => r.Car) 
                .WithMany(c => c.Reviews) 
                .HasForeignKey(r => r.CarId) 
                .OnDelete(DeleteBehavior.Cascade); 
            
            builder.Entity<Review>() 
                .HasOne(r => r.User) 
                .WithMany(u => u.Reviews) 
                .HasForeignKey(r => r.UserId) 
                .OnDelete(DeleteBehavior.Cascade); }

        }
}
