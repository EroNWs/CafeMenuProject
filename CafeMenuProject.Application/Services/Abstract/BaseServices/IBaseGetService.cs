using CafeMenuProject.ViewModel.Abstract;

namespace CafeMenuProject.Application.Services.Abstract.BaseServices;

/// <summary>
/// The base interface for retrieving entities.
/// </summary>
/// <typeparam name="T">The type of the entity to retrieve, must implement IViewModel.</typeparam>
/// <remarks>
/// This interface defines methods and operations for retrieving entities.
/// It includes methods to get all entities and find an entity by its ID.
/// </remarks>
public interface IBaseGetService<T> where T : IViewModel
{
	/// <summary>
	/// Asynchronously retrieves all entities of type <typeparamref name="T"/>.
	/// </summary>
	/// <returns>An <see cref="IEnumerable{T}"/> containing all entities of type <typeparamref name="T"/>.</returns>
	Task<IEnumerable<T>> GetAllAsync();

	/// <summary>
	/// Finds an entity by its unique identifier.
	/// </summary>
	/// <param name="id">The unique identifier of the entity to find.</param>
	/// <returns>The entity with the specified ID, or null if not found.</returns>
	T Find(Guid id);
}
