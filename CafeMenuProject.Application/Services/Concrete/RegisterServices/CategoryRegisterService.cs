using CafeMenuProject.Application.Repositories;
using CafeMenuProject.Application.Services.Abstract.RegisterServices;
using CafeMenuProject.Mapper.Abstract.CreateMapper;
using CafeMenuProject.ViewModel.Concrete.Create;

namespace CafeMenuProject.Application.Services.Concrete.RegisterServices;

public class CategoryRegisterService : ICategoryRegisterService
{
	private readonly ICategoryRepository _categoryRepository;
	private readonly ICategoryCreateMapper _categoryCreateMapper;

	public CategoryRegisterService(ICategoryRepository categoryRepository, ICategoryCreateMapper categoryCreateMapper)
	{
		_categoryRepository = categoryRepository;
		_categoryCreateMapper = categoryCreateMapper;
	}

	public async Task AddAsync(CategoryCreateVM model)
	{
		await _categoryRepository.AddAsync(_categoryCreateMapper.GeneralConvertor(model));
	}

	public async Task SaveChangesAsync()
	{
		await _categoryRepository.SaveAsync();
	}
}
