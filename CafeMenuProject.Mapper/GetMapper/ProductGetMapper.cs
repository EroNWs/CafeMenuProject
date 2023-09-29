using CafeMenuProject.Domain.Entities;
using CafeMenuProject.Mapper.Abstract.GetMapper;
using CafeMenuProject.ViewModel.Concrete.Get;

namespace CafeMenuProject.Mapper.GetMapper;

/// <summary>
/// Mapper class for converting Product entities to ProductGetVM view models.
/// Implements the IProductGetMapper interface.
/// </summary>
public class ProductGetMapper : IProductGetMapper
{
	/// <summary>
	/// Converts a Product entity to a ProductGetVM view model.
	/// </summary>
	/// <param name="model">The Product entity to be converted.</param>
	/// <returns>The converted ProductGetVM view model.</returns>
	public ProductGetVM GeneralConvertor(Product model)
=> new ProductGetVM(

	model.Id,
	model.ProductName,
	model.Price,
	model.ImagePath
	);


}
