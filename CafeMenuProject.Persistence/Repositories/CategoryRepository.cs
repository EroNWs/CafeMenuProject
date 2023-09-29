using CafeMenuProject.Application.Repositories;
using CafeMenuProject.Domain.Entities;
using CafeMenuProject.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace CafeMenuProject.Persistence.Repositories;

/// <summary>
/// Repository implementation for accessing and managing Category entities in the database.
/// </summary>
public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
{
	private readonly BaseDbContext _context;

	/// <summary>
	/// Initializes a new instance of the <see cref="CategoryRepository"/> class.
	/// </summary>
	/// <param name="context">The database context.</param>
	public CategoryRepository(BaseDbContext context) : base(context)
	{
		_context = context;
	}

	/// <summary>
	/// Retrieves a list of categories with associated product counts asynchronously.
	/// </summary>
	/// <returns>A task representing the asynchronous operation that returns a list of categories with product counts.</returns>
	public Task<List<Category>> GetCategoriesWithProductCount()
	{
		var categoriesWithProductCount = _context.Categories.Include(category => category.Products).ToListAsync();

		return categoriesWithProductCount;

	}
}
