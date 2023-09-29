using CafeMenuProject.Domain.Entities;
using CafeMenuProject.Mapper.BaseMapper;
using CafeMenuProject.ViewModel.Concrete.Get;

namespace CafeMenuProject.Mapper.Abstract.GetMapper;

/// <summary>
/// Interface for mapping operations between PropertyGetVM view models and Property entities.
/// Inherits from IBaseMapper for basic mapping functionalities.
/// </summary>
public interface IPropertyGetMapper:IBaseMapper<PropertyGetVM, Property>
{
}

