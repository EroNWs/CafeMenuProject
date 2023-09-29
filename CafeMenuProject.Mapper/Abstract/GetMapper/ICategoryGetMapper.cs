using CafeMenuProject.Domain.Entities;
using CafeMenuProject.Mapper.BaseMapper;
using CafeMenuProject.ViewModel.Concrete.Get;

namespace CafeMenuProject.Mapper.Abstract.GetMapper;

/// <summary>
/// Interface for mapping operations between CategoryGetVM view models and Category entities.
/// Inherits from IBaseMapper for basic mapping functionalities.
/// </summary>
public interface ICategoryGetMapper : IBaseMapper<CategoryGetVM, Category>
{
}
