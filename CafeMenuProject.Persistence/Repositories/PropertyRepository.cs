using CafeMenuProject.Application.Repositories;
using CafeMenuProject.Domain.Entities;
using CafeMenuProject.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace CafeMenuProject.Persistence.Repositories;

/// <summary>
/// Repository implementation for accessing and managing Property entities in the database.
/// </summary>
public class PropertyRepository : IPropertyRepository
{
	private readonly BaseDbContext _context;

	/// <summary>
	/// Initializes a new instance of the <see cref="PropertyRepository"/> class.
	/// </summary>
	/// <param name="context">The database context.</param>
	public PropertyRepository(BaseDbContext context)
	{
		_context = context;
	}

	public async Task AddAsync(Property entity)
	{
		await _context.Set<Property>().AddAsync(entity);
	}

	public async void DeleteAsync(Guid id)
	{
		var entity = await _context.Set<Property>().FindAsync(id);
		_context.Set<Property>().Remove(entity);
	}

	public Property Find(Guid id)
	{
		var query = _context.Set<Property>().Find(id);
		return query;
	}

	public async Task<IEnumerable<Property>> GetAllAsync()
	{
		await Task.Delay(1000);
		IQueryable<Property> query = _context.Set<Property>();
		return await query.ToListAsync();

	}

	public async Task SaveAsync()
	{
		await _context.SaveChangesAsync();
	}

	public void Update(Property entity)
	{
		_context.Update(entity);
	}

	Task IPropertyRepository.DeleteAsync(Guid id)
	{
		throw new NotImplementedException();
	}
}
