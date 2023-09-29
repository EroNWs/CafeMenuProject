using CafeMenuProject.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CafeMenuProject.Persistence.Contexts;

/// <summary>
/// Represents the main database context for the application, derived from IdentityDbContext.
/// Includes DbSets for Category, Product, Property, and User entities.
/// </summary>
public class BaseDbContext : IdentityDbContext<IdentityUser>
{
	/// <summary>
	/// Gets or sets the DbSet for Category entities.
	/// </summary>
	public DbSet<Category> Categories { get; set; }

	/// <summary>
	/// Gets or sets the DbSet for Product entities.
	/// </summary>
	public DbSet<Product> Products { get; set; }

	/// <summary>
	/// Gets or sets the DbSet for Property entities.
	/// </summary>
	public DbSet<Property> Properties { get; set; }

	/// <summary>
	/// Gets or sets the DbSet for User entities.
	/// </summary>
	public DbSet<User> Users { get; set; }

	/// <summary>
	/// Initializes a new instance of the BaseDbContext class.
	/// </summary>
	/// <param name="options">The options to be used by the context.</param>
	public BaseDbContext(DbContextOptions<BaseDbContext> options) : base(options)
	{
	}

	/// <summary>
	/// Configures the model and relationships for the database context.
	/// </summary>
	/// <param name="modelBuilder">The model builder instance.</param>
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);
	}
}
