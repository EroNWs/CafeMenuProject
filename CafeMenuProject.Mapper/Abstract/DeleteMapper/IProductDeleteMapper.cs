using CafeMenuProject.Domain.Entities;
using CafeMenuProject.Mapper.BaseMapper;
using CafeMenuProject.ViewModel.Concrete.Delete;

namespace CafeMenuProject.Mapper.Abstract.DeleteMapper;

/// <summary>
/// Interface for mapping operations between Product entities and ProductDeleteVM view models.
/// Inherits from IBaseMapper for basic mapping functionalities.
/// </summary>
public interface IProductDeleteMapper : IBaseMapper<Product, ProductDeleteVM>
{
}
