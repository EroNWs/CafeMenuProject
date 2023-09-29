using CafeMenuProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CafeMenuProject.Persistence.EntityConfigurations;

/// <summary>
/// Represents the configuration for the ProductProperty entity in the database context.
/// </summary>
public class ProductPropertyConfiguration : IEntityTypeConfiguration<ProductProperty>
{
	/// <summary>
	/// Configures the database schema and relationships for the ProductProperty entity.
	/// </summary>
	/// <param name="builder">The entity type builder used to configure the ProductProperty entity.</param>
	public void Configure(EntityTypeBuilder<ProductProperty> builder)
	{
		builder.ToTable("ProductProperty").HasKey(p => p.ProductPropertyId);

		builder.HasOne(p => p.Property);
		builder.HasOne(p => p.Product);


	}
}
