using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication1.Entities.Config;

public class ProductEfConfig : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(x => x.IdProduct).HasName("IdProduct");
        builder.Property(x => x.IdProduct).UseIdentityColumn();

        builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
        builder.Property(x => x.Quality).IsRequired().HasMaxLength(40);

        builder.ToTable("Product");

        Product[] products =
        {
            new Product()
            {
                IdProduct = 1, Name = "Szczotka", Quality = "Nowa"
            },
            new Product()
            {
                IdProduct = 2, Name = "Buty", Quality = "Nowe"
            },
            new Product()
            {
                IdProduct = 3, Name = "Rower", Quality = "Używane"
            }
        };

        builder.HasData(products);
    }
}