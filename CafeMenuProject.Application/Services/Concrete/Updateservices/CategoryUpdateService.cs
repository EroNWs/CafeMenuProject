using CafeMenuProject.Application.Repositories;
using CafeMenuProject.Application.Services.Abstract.UpdateServices;
using CafeMenuProject.Mapper.Abstract.UpdateMapper;
using CafeMenuProject.ViewModel.Concrete.Update;

namespace CafeMenuProject.Application.Services.Concrete.Updateservices;

public class CategoryUpdateService : ICategoryUpdateService
{
	private readonly ICategoryRepository _categoryRepository;
	private readonly ICategoryUpdateMapper _categoryUpdateMapper;

	public CategoryUpdateService(ICategoryRepository categoryRepository, ICategoryUpdateMapper categoryUpdateMapper)
	{
		_categoryRepository = categoryRepository;
		_categoryUpdateMapper = categoryUpdateMapper;
	}

	public async Task SaveAsync()
	{
		await _categoryRepository.SaveAsync();
	}

	public async void Update(CategoryUpdateVM model)
	{
		_categoryRepository.Update(_categoryUpdateMapper.GeneralConvertor(model));
	}
}
