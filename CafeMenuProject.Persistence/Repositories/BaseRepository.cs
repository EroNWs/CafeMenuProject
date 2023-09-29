using CafeMenuProject.Application.Repositories;
using CafeMenuProject.Domain.Abstract;
using CafeMenuProject.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace CafeMenuProject.Persistence.Repositories;

/// <summary>
/// A base repository for managing entities with basic CRUD operations.
/// </summary>
/// <typeparam name="T">The type of entity to manage.</typeparam>
public class BaseRepository<T> :IBaseRepository<T> where T: BaseEntity
{
	private readonly BaseDbContext _context;

	/// <summary>
	/// Initializes a new instance of the <see cref="BaseRepository{T}"/> class.
	/// </summary>
	/// <param name="context">The application's database context.</param>
	public BaseRepository(BaseDbContext context)
	{
		_context = context;
	}

	public async Task AddAsync(T entity)
	{
		await _context.Set<T>().AddAsync(entity);
	}

	public async void DeleteAsync(Guid id)
	{
		await SetEntityAsDeletedAsync(id);			
	}

	public T Find(Guid id)
	{
		var query = _context.Set<T>().Find(id);
		return query;
	}

	public async Task<IEnumerable<T>> GetAllAsync()
	{
		await Task.Delay(1000);
		IQueryable<T> query = _context.Set<T>();
		return await query.ToListAsync(); 


	}

	/// <summary>
	/// Asynchronously saves changes made to the repository.
	/// </summary>
	/// <returns>A Task representing the asynchronous operation.</returns>
	public async Task SaveAsync()
	{
		await _context.SaveChangesAsync();
	}

	/// <summary>
	/// Updates an entity in the repository.
	/// </summary>
	/// <param name="entity">The entity to update.</param>
	public void Update(T entity)
	{
		_context.Update(entity);
	}


	public async Task SetEntityAsDeletedAsync(Guid id)
	{
		
		var entity = await _context.Set<T>().FindAsync(id);

		if (entity != null)
		{
			entity.IsDeleted = true;
			_context.Set<T>().Update(entity);
			await _context.SaveChangesAsync();
		}
					
	}


}
