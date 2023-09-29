using CafeMenuProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CafeMenuProject.Persistence.EntityConfigurations;

/// <summary>
/// Represents the configuration for the Product entity in the database context.
/// </summary>
public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
	/// <summary>
	/// Configures the database schema and relationships for the Product entity.
	/// </summary>
	/// <param name="builder">The entity type builder used to configure the Product entity.</param>
	public void Configure(EntityTypeBuilder<Product> builder)
	{
		builder.ToTable("Product").HasKey(p => p.Id);

		builder.Property(p => p.Id).HasColumnName("PRODUCTID").IsRequired();
		builder.Property(p => p.ProductName).HasColumnName("PRODUCTNAME").IsRequired().HasMaxLength(50);
		builder.Property(p => p.CategoryId).HasColumnName("CATEGORYID");
		builder.Property(p => p.Price).HasColumnName("PRICE").IsRequired().HasColumnType("money");
		builder.Property(p => p.ImagePath).HasColumnName("IMAGEPATH");
		builder.Property(c => c.IsDeleted).HasColumnName("ISDELETED");
		builder.Property(c => c.CreatedDate).HasColumnName("CREATEDDATE");
		builder.Property(c => c.CreatorUserId).HasColumnName("CREATORUSERID");

		builder.HasOne(p => p.Category);
		builder.HasMany(p => p.ProductProperties);

	}
}
