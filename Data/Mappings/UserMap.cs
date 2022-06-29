using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductsCatalog.Models;

namespace ProductsCatalog.Data.Mappings
{

    public class UserMap : IEntityTypeConfiguration<UserModel>
    {
        public void Configure(EntityTypeBuilder<UserModel> builder)
        {
            builder.ToTable("User");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder.HasIndex(x => x.Id, "IX_Product_Name").IsUnique();

            builder.Property(x => x.GUID)
                .IsRequired()
                .HasColumnName("GUID");

            builder.HasIndex(x => x.Id, "IX_Product_Name").IsUnique();

            builder.Property(x => x.Active)
            .IsRequired()
            .HasColumnName("Active_Status")
            .HasColumnType("BIT");
        }
    }
}
