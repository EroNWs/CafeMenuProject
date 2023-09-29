using CafeMenuProject.Domain.Entities;
using CafeMenuProject.Mapper.Abstract.CreateMapper;
using CafeMenuProject.ViewModel.Concrete.Create;

namespace CafeMenuProject.Mapper.CreateMapper;

/// <summary>
/// Mapper class for converting ProductCreateVM view models to Product entities.
/// Implements the IProductCreateMapper interface.
/// </summary>
public class ProductCreateMapper : IProductCreateMapper
{
	/// <summary>
	/// Converts a ProductCreateVM object to a Product entity.
	/// </summary>
	/// <param name="model">The ProductCreateVM object to be converted.</param>
	/// <returns>The converted Product entity.</returns>
	public Product GeneralConvertor(ProductCreateVM model)
=> new Product
{
	Id = Guid.NewGuid(),
	ProductName = model.ProductName,
	Price = model.Price,
	ImagePath = model.ImagePath,
	CategoryId = model.CategoryId,
	IsDeleted = false,
	CreatedDate = DateTime.UtcNow,
	CreatorUserId = "a70fd072-f131-4120-b2ed-b46152d1081a"

};
}
