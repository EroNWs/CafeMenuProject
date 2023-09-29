using CafeMenuProject.Domain.Entities;
using CafeMenuProject.Mapper.BaseMapper;
using CafeMenuProject.ViewModel.Concrete.Get;

namespace CafeMenuProject.Mapper.Abstract.GetMapper;

/// <summary>
/// Interface for mapping operations between ProductGetVM view models and Product entities.
/// Inherits from IBaseMapper for basic mapping functionalities.
/// </summary>
public interface IProductGetMapper : IBaseMapper<ProductGetVM, Product>
{
}
