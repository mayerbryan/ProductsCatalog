using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductsCatalog.Models;

namespace ProductsCatalog.Data.Mappings
{

    public class ProductMap : IEntityTypeConfiguration<ProductModel>
    {
        public void Configure(EntityTypeBuilder<ProductModel> builder)
        {
            builder.ToTable("Product");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(1500);

            builder.Property(x => x.SKU)
            .IsRequired()
            .HasColumnName("SKU")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(255);

            builder.HasIndex(x => x.SKU, "IX_Product_Name").IsUnique();

            builder.Property(x => x.Price)
                .IsRequired()
                .HasColumnName("Price")
                .HasColumnType("DECIMAL");

            builder.Property(x => x.Description)
                .IsRequired()
                .HasColumnName("Description")
                .HasColumnType("MEDIUMTEXT");

            builder.HasIndex(x => x.Name, "IX_Product_Name");

        }
    }
}