using CafeMenuProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CafeMenuProject.Persistence.EntityConfigurations;

/// <summary>
/// Represents the configuration for the User entity in the database context.
/// </summary>
public class UserConfiguration : IEntityTypeConfiguration<User>
{
	/// <summary>
	/// Configures the database schema for the User entity.
	/// </summary>
	/// <param name="builder">The entity type builder used to configure the User entity.</param>
	public void Configure(EntityTypeBuilder<User> builder)
	{
		builder.ToTable("User").HasKey(u => u.Id);

		builder.Property(u => u.Id).HasColumnName("USERID").IsRequired();
		builder.Property(u => u.Name).HasColumnName("NAME").IsRequired().HasMaxLength(50);
		builder.Property(u => u.Surname).HasColumnName("SURNAME").IsRequired().HasMaxLength(50);
		builder.Property(u => u.UserName).HasColumnName("USERNAME").IsRequired().HasMaxLength(50);
	}
}
