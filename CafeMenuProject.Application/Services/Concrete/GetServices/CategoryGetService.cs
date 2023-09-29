using CafeMenuProject.Application.Repositories;
using CafeMenuProject.Application.Services.Abstract.GetServices;
using CafeMenuProject.Mapper.Abstract.GetMapper;
using CafeMenuProject.ViewModel.Concrete.Get;

namespace CafeMenuProject.Application.Services.Concrete.GetServices;

public class CategoryGetService : ICategoryGetService
{
	private readonly ICategoryRepository _categoryRepository;
	private readonly ICategoryGetMapper _categoryGetMapper;

	public CategoryGetService(ICategoryRepository categoryRepository, ICategoryGetMapper categoryGetMapper)
	{
		_categoryRepository = categoryRepository;
		_categoryGetMapper = categoryGetMapper;
	}

	public CategoryGetVM Find(Guid id)
	{
		var query = _categoryRepository.Find(id);
		var data = _categoryGetMapper.GeneralConvertor(query);
		return data;
	}

	public async Task<IEnumerable<CategoryGetVM>> GetAllAsync()
	{
		var query = await _categoryRepository.GetAllAsync();
		List<CategoryGetVM> categoryGetVMs = new List<CategoryGetVM>();

		foreach (var item in query)
		{
			var categoryGetVM = _categoryGetMapper.GeneralConvertor(item);
			categoryGetVMs.Add(categoryGetVM);
		}

		return categoryGetVMs;
	}

	public async Task<IEnumerable<CategoryNameWithProductCountGetVM>> GetCategoriesWithProductCount()
	{
		var categories = await _categoryRepository.GetCategoriesWithProductCount();

		var categoriesWithProductCount = categories.Select(category => new CategoryNameWithProductCountGetVM
		{
			CategoryName = category.CategoryName,
			ProductCount = category.Products.Count
		});

		return categoriesWithProductCount;
	}



}
