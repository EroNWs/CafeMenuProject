using CafeMenuProject.Application.Repositories;
using CafeMenuProject.Domain.Entities;
using CafeMenuProject.Persistence.Contexts;

namespace CafeMenuProject.Persistence.Repositories;

/// <summary>
/// Repository implementation for accessing and managing Product entities in the database.
/// </summary>
public class ProductRepository : BaseRepository<Product>, IProductRepository
{
	private readonly BaseDbContext _context;

	/// <summary>
	/// Initializes a new instance of the <see cref="ProductRepository"/> class.
	/// </summary>
	/// <param name="context">The database context.</param>
	public ProductRepository(BaseDbContext context) : base(context)
	{
		_context = context;
	}
}
