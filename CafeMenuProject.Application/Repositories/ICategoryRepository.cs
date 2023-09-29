using CafeMenuProject.Domain.Entities;

namespace CafeMenuProject.Application.Repositories;

/// <summary>
/// Interface representing a repository for the Category entities.
/// Extends the base repository for Category entities.
/// </summary>
public interface ICategoryRepository : IBaseRepository<Category>
{
	/// <summary>
	/// Asynchronously retrieves a list of categories along with the count of associated products.
	/// </summary>
	/// <returns>A task that represents the asynchronous operation, returning a list of categories with product count.</returns>
	Task<List<Category>> GetCategoriesWithProductCount();
}
