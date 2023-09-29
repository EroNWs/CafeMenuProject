using CafeMenuProject.Domain.Entities;
using CafeMenuProject.Mapper.Abstract.CreateMapper;
using CafeMenuProject.ViewModel.Concrete.Create;

namespace CafeMenuProject.Mapper.CreateMapper;

/// <summary>
/// Mapper class for converting CategoryCreateVM view models to Category entities.
/// Implements the ICategoryCreateMapper interface.
/// </summary>
public class CategoryCreateMapper : ICategoryCreateMapper
{
	/// <summary>
	/// Converts a CategoryCreateVM object to a Category entity.
	/// </summary>
	/// <param name="model">The CategoryCreateVM object to be converted.</param>
	/// <returns>The converted Category entity.</returns>
	public Category GeneralConvertor(CategoryCreateVM model)
	=> new Category
	{

		Id = Guid.NewGuid(),
		CategoryName = model.CategoryName,
		ParentCategoryId = model.ParentCategoryId == null ? null : model.ParentCategoryId,
		IsDeleted = false,
		CreatedDate = DateTime.UtcNow,
		CreatorUserId = "a70fd072-f131-4120-b2ed-b46152d1081a"


	};
}
