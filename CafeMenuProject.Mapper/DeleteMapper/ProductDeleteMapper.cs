using CafeMenuProject.Domain.Entities;
using CafeMenuProject.Mapper.Abstract.DeleteMapper;
using CafeMenuProject.ViewModel.Concrete.Delete;

namespace CafeMenuProject.Mapper.DeleteMapper;

/// <summary>
/// Mapper class for converting ProductDeleteVM view models to Product entities.
/// Implements the IProductDeleteMapper interface.
/// </summary>
public class ProductDeleteMapper : IProductDeleteMapper
{
	/// <summary>
	/// Converts a ProductDeleteVM object to a Product entity.
	/// </summary>
	/// <param name="model">The ProductDeleteVM object to be converted.</param>
	/// <returns>The converted Product entity.</returns>
	public Product GeneralConvertor(ProductDeleteVM model)
	{
		throw new NotImplementedException();
	}
}
