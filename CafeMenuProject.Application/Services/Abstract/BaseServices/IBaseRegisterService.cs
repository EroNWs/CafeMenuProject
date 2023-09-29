using CafeMenuProject.ViewModel.Abstract;

namespace CafeMenuProject.Application.Services.Abstract.BaseServices;


/// <summary>
/// The base interface for registering entities.
/// </summary>
/// <typeparam name="T">The type of the entity to register, must implement IViewModel.</typeparam>
/// <remarks>
/// This interface defines methods and operations for registering (adding) entities.
/// It includes methods to asynchronously add an entity and save changes to the underlying data store.
/// </remarks>
public interface IBaseRegisterService<T> where T : IViewModel
{
	/// <summary>
	/// Asynchronously adds an entity of type <typeparamref name="T"/>.
	/// </summary>
	/// <param name="model">The entity to be added.</param>
	/// <returns>A task that represents the asynchronous operation.</returns>
	Task AddAsync(T model);

	/// <summary>
	/// Asynchronously saves changes to the underlying data store.
	/// </summary>
	/// <returns>A task that represents the asynchronous operation.</returns>
	Task SaveChangesAsync();
}
