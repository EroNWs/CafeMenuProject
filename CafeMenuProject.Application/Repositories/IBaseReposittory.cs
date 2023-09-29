using CafeMenuProject.Domain.Abstract;

namespace CafeMenuProject.Application.Repositories;

/// <summary>
/// Interface representing a generic repository for entities derived from BaseEntity.
/// </summary>
/// <typeparam name="T">The type of entity the repository works with, must be derived from BaseEntity.</typeparam>
public interface IBaseRepository<T> where T : BaseEntity
{
	/// <summary>
	/// Asynchronously adds a new entity to the repository.
	/// </summary>
	/// <param name="entity">The entity to add.</param>
	/// <returns>A task that represents the asynchronous operation.</returns>
	Task AddAsync(T entity);


	/// <summary>
	/// Asynchronously deletes an entity from the repository by its unique identifier.
	/// </summary>
	/// <param name="id">The unique identifier of the entity to delete.</param>
	/// <returns>A task that represents the asynchronous operation.</returns>
	void DeleteAsync(Guid id);


	/// <summary>
	/// Updates an existing entity in the repository.
	/// </summary>
	/// <param name="entity">The entity to update.</param>
	void Update(T entity);

	/// <summary>
	/// Asynchronously saves changes made to the repository.
	/// </summary>
	/// <returns>A task that represents the asynchronous operation.</returns>
	Task SaveAsync();

	/// <summary>
	/// Asynchronously retrieves all entities from the repository.
	/// </summary>
	/// <returns>A collection of all entities in the repository.</returns>
	Task<IEnumerable<T>> GetAllAsync();

	/// <summary>
	/// Finds an entity by its unique identifier.
	/// </summary>
	/// <param name="id">The unique identifier of the entity to find.</param>
	/// <returns>The found entity or null if not found.</returns>
	T Find(Guid id);

}
