using CafeMenuProject.Domain.Entities;
using CafeMenuProject.Mapper.BaseMapper;
using CafeMenuProject.ViewModel.Concrete.Update;

namespace CafeMenuProject.Mapper.Abstract.UpdateMapper;

/// <summary>
/// Interface for mapping operations between Property entities and PropertyUpdateVM view models.
/// Inherits from IBaseMapper for basic mapping functionalities.
/// </summary>
public interface IPropertyUpdateMapper : IBaseMapper<Property, PropertyUpdateVM>
{
}
