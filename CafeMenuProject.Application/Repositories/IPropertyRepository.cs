using CafeMenuProject.Domain.Entities;

namespace CafeMenuProject.Application.Repositories;


/// <summary>
/// Interface representing a repository for the Property entities.
/// </summary>
public interface IPropertyRepository
{
	/// <summary>
	/// Asynchronously adds a new property entity to the repository.
	/// </summary>
	/// <param name="entity">The property entity to add.</param>
	/// <returns>A task that represents the asynchronous operation.</returns>
	Task AddAsync(Property entity);

	/// <summary>
	/// Asynchronously deletes a property entity from the repository by its unique identifier.
	/// </summary>
	/// <param name="id">The unique identifier of the property entity to delete.</param>
	/// <returns>A task that represents the asynchronous operation.</returns>
	Task DeleteAsync(Guid id);

	/// <summary>
	/// Updates an existing property entity in the repository.
	/// </summary>
	/// <param name="entity">The property entity to update.</param>
	void Update(Property entity);

	/// <summary>
	/// Asynchronously saves changes made to the repository.
	/// </summary>
	/// <returns>A task that represents the asynchronous operation.</returns>
	Task SaveAsync();

	/// <summary>
	/// Asynchronously retrieves all property entities from the repository.
	/// </summary>
	/// <returns>A task that represents the asynchronous operation, returning a collection of all property entities in the repository.</returns>
	Task<IEnumerable<Property>> GetAllAsync();

	/// <summary>
	/// Finds a property entity by its unique identifier.
	/// </summary>
	/// <param name="id">The unique identifier of the property entity to find.</param>
	/// <returns>The found property entity or null if not found.</returns>
	Property Find(Guid id);
}
