using CafeMenuProject.Domain.Entities;
using CafeMenuProject.Mapper.Abstract.CreateMapper;
using CafeMenuProject.ViewModel.Concrete.Create;

namespace CafeMenuProject.Mapper.CreateMapper;

/// <summary>
/// Mapper class for converting PropertyCreateVM view models to Property entities.
/// Implements the IPropertyCreateMapper interface.
/// </summary>
public class PropertyCreateMapper : IPropertyCreateMapper
{
	/// <summary>
	/// Converts a PropertyCreateVM object to a Property entity.
	/// </summary>
	/// <param name="model">The PropertyCreateVM object to be converted.</param>
	/// <returns>The converted Property entity.</returns>
	public Property GeneralConvertor(PropertyCreateVM model)
	{
		Property property = new Property
		{
			Id = Guid.NewGuid(),
			KeyValuePairs = new Dictionary<string, string>
			{
				{ model.Key, model.Value }
			}
		};

		return property;
	}
}
