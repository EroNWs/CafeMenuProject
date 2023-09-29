using CafeMenuProject.Domain.Entities;
using CafeMenuProject.Mapper.Abstract.DeleteMapper;
using CafeMenuProject.ViewModel.Concrete.Delete;

namespace CafeMenuProject.Mapper.DeleteMapper;

/// <summary>
/// Mapper class for converting CategoryDeleteVM view models to Category entities.
/// Implements the ICategoryDeleteMapper interface.
/// </summary>
public class CategoryDeleteMapper : ICategoryDeleteMapper
{
	/// <summary>
	/// Converts a CategoryDeleteVM object to a Category entity.
	/// </summary>
	/// <param name="model">The CategoryDeleteVM object to be converted.</param>
	/// <returns>The converted Category entity.</returns>
	public Category GeneralConvertor(CategoryDeleteVM model)
	{
		throw new NotImplementedException();
	}
}
