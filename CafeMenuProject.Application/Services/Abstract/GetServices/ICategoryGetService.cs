using CafeMenuProject.Application.Services.Abstract.BaseServices;
using CafeMenuProject.ViewModel.Concrete.Get;

namespace CafeMenuProject.Application.Services.Abstract.GetServices;

/// <summary>
/// Interface representing a service for retrieving CategoryGetVM entities.
/// Extends the base get service for CategoryGetVM entities.
/// </summary>
public interface ICategoryGetService : IBaseGetService<CategoryGetVM>
{
	/// <summary>
	/// Asynchronously retrieves a collection of categories with product count information.
	/// </summary>
	/// <returns>A task that represents the asynchronous operation, returning a collection of categories with product count.</returns>
	Task<IEnumerable<CategoryNameWithProductCountGetVM>> GetCategoriesWithProductCount();

}
