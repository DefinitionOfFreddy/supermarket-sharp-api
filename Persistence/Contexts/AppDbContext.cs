
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory.ValueGeneration.Internal;
using supermarket.sharp.api.Domain.Models;

namespace supermarket.sharp.api.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }
       
    }
}