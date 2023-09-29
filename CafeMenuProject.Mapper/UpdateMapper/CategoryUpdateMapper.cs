using CafeMenuProject.Domain.Entities;
using CafeMenuProject.Mapper.Abstract.UpdateMapper;
using CafeMenuProject.ViewModel.Concrete.Update;

namespace CafeMenuProject.Mapper.UpdateMapper;

/// <summary>
/// Mapper class responsible for converting CategoryUpdateVM to Category entities for update operations.
/// </summary>
public class CategoryUpdateMapper : ICategoryUpdateMapper
{
	public Category GeneralConvertor(CategoryUpdateVM model)
	=> new Category
	{
		CategoryName = model.CategoryName,

	};
}
