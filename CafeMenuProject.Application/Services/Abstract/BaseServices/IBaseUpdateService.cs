using CafeMenuProject.ViewModel.Abstract;

namespace CafeMenuProject.Application.Services.Abstract.BaseServices;

/// <summary>
/// The base interface for updating entities.
/// </summary>
/// <typeparam name="T">The type of the entity to update, must implement IViewModel.</typeparam>
/// <remarks>
/// This interface defines methods and operations for updating entities.
/// It includes methods to update an entity and save changes to the underlying data store asynchronously.
/// </remarks>
public interface IBaseUpdateService<T> where T : IViewModel
{
	/// <summary>
	/// Updates an entity of type <typeparamref name="T"/>.
	/// </summary>
	/// <param name="model">The entity to be updated.</param>
	void Update(T model);

	/// <summary>
	/// Asynchronously saves changes to the underlying data store.
	/// </summary>
	/// <returns>A task that represents the asynchronous save operation.</returns>
	Task SaveAsync();
}
}
