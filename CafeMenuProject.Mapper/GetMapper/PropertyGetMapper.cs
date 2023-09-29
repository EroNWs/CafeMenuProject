using CafeMenuProject.Domain.Entities;
using CafeMenuProject.Mapper.Abstract.GetMapper;
using CafeMenuProject.ViewModel.Concrete.Get;

namespace CafeMenuProject.Mapper.GetMapper;

/// <summary>
/// Mapper class for converting Property entities to PropertyGetVM view models.
/// Implements the IPropertyGetMapper interface.
/// </summary>
public class PropertyGetMapper : IPropertyGetMapper
{
	/// <summary>
	/// Converts a Property entity to a PropertyGetVM view model.
	/// </summary>
	/// <param name="model">The Property entity to be converted.</param>
	/// <returns>The converted PropertyGetVM view model.</returns>
	public PropertyGetVM GeneralConvertor(Property model)
	{
		throw new NotImplementedException();
	}
}
