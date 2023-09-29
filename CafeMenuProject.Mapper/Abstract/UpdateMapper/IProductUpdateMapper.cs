using CafeMenuProject.Domain.Entities;
using CafeMenuProject.Mapper.BaseMapper;
using CafeMenuProject.ViewModel.Concrete.Update;

namespace CafeMenuProject.Mapper.Abstract.UpdateMapper;

/// <summary>
/// Interface for mapping operations between Product entities and ProductUpdateVM view models.
/// Inherits from IBaseMapper for basic mapping functionalities.
/// </summary>
public interface IProductUpdateMapper : IBaseMapper<Product, ProductUpdateVM>
{
}
