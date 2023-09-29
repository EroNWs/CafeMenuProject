using CafeMenuProject.Domain.Entities;
using CafeMenuProject.Mapper.Abstract.GetMapper;
using CafeMenuProject.ViewModel.Concrete.Get;

namespace CafeMenuProject.Mapper.GetMapper;

/// <summary>
/// Mapper class for converting Category entities to CategoryGetVM view models.
/// Implements the ICategoryGetMapper interface.
/// </summary>
public class CategoryGetMapper : ICategoryGetMapper
{
	/// <summary>
	/// Converts a Category entity to a CategoryGetVM view model.
	/// </summary>
	/// <param name="model">The Category entity to be converted.</param>
	/// <returns>The converted CategoryGetVM view model.</returns>
	public CategoryGetVM GeneralConvertor(Category model)
	=> new CategoryGetVM(
		model.Id,
		model.CategoryName

		);
}
