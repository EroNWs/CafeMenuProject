using CafeMenuProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CafeMenuProject.Persistence.EntityConfigurations;

/// <summary>
/// Represents the configuration for the Category entity in the database context.
/// </summary>
public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
	/// <summary>
	/// Configures the database schema and relationships for the Category entity.
	/// </summary>
	/// <param name="builder">The entity type builder used to configure the Category entity.</param>
	public void Configure(EntityTypeBuilder<Category> builder)
	{
		builder.ToTable("Category").HasKey(c => c.Id);

		builder.Property(c => c.Id).HasColumnName("CATEGORYID").IsRequired();
		builder.Property(c => c.CategoryName).HasColumnName("CATEGORYNAME").IsRequired();
		builder.Property(c => c.ParentCategoryId).HasColumnName("PARENTCATEGORYID");
		builder.Property(c => c.IsDeleted).HasColumnName("ISDELETED");
		builder.Property(c => c.CreatedDate).HasColumnName("CREATEDDATE");
		builder.Property(c => c.CreatorUserId).HasColumnName("CREATORUSERID");


		builder.HasMany(c => c.Products);

	}
}
