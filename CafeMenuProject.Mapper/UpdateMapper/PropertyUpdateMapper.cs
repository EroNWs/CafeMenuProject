using CafeMenuProject.Domain.Entities;
using CafeMenuProject.Mapper.Abstract.UpdateMapper;
using CafeMenuProject.ViewModel.Concrete.Update;

namespace CafeMenuProject.Mapper.UpdateMapper;

/// <summary>
/// Mapper class responsible for converting PropertyUpdateVM to Property entities for update operations.
/// </summary>
public class PropertyUpdateMapper : IPropertyUpdateMapper
{
	public Property GeneralConvertor(PropertyUpdateVM model)
	{
		throw new NotImplementedException();
	}
}
