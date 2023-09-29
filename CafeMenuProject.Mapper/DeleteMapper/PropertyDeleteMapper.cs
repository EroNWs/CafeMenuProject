using CafeMenuProject.Domain.Entities;
using CafeMenuProject.Mapper.Abstract.DeleteMapper;
using CafeMenuProject.ViewModel.Concrete.Delete;

namespace CafeMenuProject.Mapper.DeleteMapper;

/// <summary>
/// Mapper class for converting PropertyDeleteVM view models to Property entities.
/// Implements the IPropertyDeleteMapper interface.
/// </summary>
public class PropertyDeleteMapper : IPropertyDeleteMapper
{
	/// <summary>
	/// Converts a PropertyDeleteVM object to a Property entity.
	/// </summary>
	/// <param name="model">The PropertyDeleteVM object to be converted.</param>
	/// <returns>The converted Property entity.</returns>
	public Property GeneralConvertor(PropertyDeleteVM model)
	{
		throw new NotImplementedException();
	}
}
