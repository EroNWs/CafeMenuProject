using CafeMenuProject.Domain.Entities;
using CafeMenuProject.Mapper.Abstract.UpdateMapper;
using CafeMenuProject.ViewModel.Concrete.Update;

namespace CafeMenuProject.Mapper.UpdateMapper;

/// <summary>
/// Mapper class responsible for converting ProductUpdateVM to Product entities for update operations.
/// </summary>
public class ProductUpdateMapper : IProductUpdateMapper
{
	public Product GeneralConvertor(ProductUpdateVM model)
	=> new Product
	{
		ProductName = model.ProductName
	};
}
