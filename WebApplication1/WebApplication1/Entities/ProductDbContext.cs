using Microsoft.EntityFrameworkCore;
using WebApplication1.Entities.Config;

namespace WebApplication1.Entities;

public class ProductDbContext : DbContext
{
    public virtual DbSet<Product> Products { get; set; }

    public ProductDbContext()
    {
    }

    public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductEfConfig).Assembly);
    }
}