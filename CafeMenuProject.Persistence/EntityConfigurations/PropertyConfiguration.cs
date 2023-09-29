using CafeMenuProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CafeMenuProject.Persistence.EntityConfigurations;

/// <summary>
/// Represents the configuration for the Property entity in the database context.
/// </summary>
public class PropertyConfiguration : IEntityTypeConfiguration<Property>
{
	/// <summary>
	/// Configures the database schema and relationships for the Property entity.
	/// </summary>
	/// <param name="builder">The entity type builder used to configure the Property entity.</param>
	public void Configure(EntityTypeBuilder<Property> builder)
	{
		builder.ToTable("Property").HasKey(p => p.Id);

		builder.Property(p => p.Id).HasColumnName("PROPERTYID").IsRequired();

		builder.OwnsOne(p => p.KeyValuePairs, kv =>
		{

			kv.ToTable("PropertyKeyValuePairs");
			kv.Property<string>("Key").HasColumnName("KEY");
			kv.Property<string>("Value").HasColumnName("VALUE");
			kv.HasKey("Key");
			kv.WithOwner().HasForeignKey("PropertyId");

		});

		builder.Property(p => p.KeyValuePairsJson)
			 .HasColumnType("jsonb");


		builder.HasMany(p => p.ProductProperties)
				 .WithOne(pp => pp.Property)
				 .HasForeignKey(pp => pp.PropertyId);



	}
}
