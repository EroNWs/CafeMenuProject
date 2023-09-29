using CafeMenuProject.ViewModel.Abstract;

namespace CafeMenuProject.Application.Services.Abstract.BaseServices;

/// <summary>
/// The base interface for deleting entities.
/// </summary>
/// <typeparam name="T">The type of the entity to delete, must implement IViewModel.</typeparam>
/// <remarks>
/// This interface defines methods and operations for deleting entities.
/// It includes a method to find an entity by its ID, delete an entity, and save changes asynchronously.
/// </remarks>
public interface IBaseDeleteService<T> where T : IViewModel
{
	/// <summary>
	/// Finds an entity by its unique identifier.
	/// </summary>
	/// <param name="id">The unique identifier of the entity to find.</param>
	/// <returns>The entity with the specified ID, or null if not found.</returns>
	T Find(Guid id);

	/// <summary>
	/// Asynchronously deletes an entity from the data store by its unique identifier.
	/// </summary>
	/// <param name="id">The unique identifier of the entity to delete.</param>
	/// <returns>A task representing the asynchronous delete operation.</returns>
	Task DeleteAsync(Guid id);

	/// <summary>
	/// Asynchronously saves changes to the data store.
	/// </summary>
	/// <returns>A task representing the asynchronous save operation.</returns>
	Task SaveAsync();
}