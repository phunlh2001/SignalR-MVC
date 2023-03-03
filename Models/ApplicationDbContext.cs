using Microsoft.EntityFrameworkCore;
using Test_SignalR.Extensions;

namespace Test_SignalR.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public ApplicationDbContext() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Products");

            // Seed data default
            modelBuilder.Seed();
        }

        public virtual DbSet<Product> Products { get; set; }
    }
}