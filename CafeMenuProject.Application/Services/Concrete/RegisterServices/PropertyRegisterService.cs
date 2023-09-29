using CafeMenuProject.Application.Repositories;
using CafeMenuProject.Application.Services.Abstract.RegisterServices;
using CafeMenuProject.Mapper.Abstract.CreateMapper;
using CafeMenuProject.ViewModel.Concrete.Create;

namespace CafeMenuProject.Application.Services.Concrete.RegisterServices;

public class PropertyRegisterService : IPropertyRegisterService
{
	private readonly IPropertyRepository _propertyRepository;
	private readonly IPropertyCreateMapper _propertyCreateMapper;

	public PropertyRegisterService(IPropertyRepository propertyRepository, IPropertyCreateMapper propertyCreateMapper)
	{
		_propertyRepository = propertyRepository;
		_propertyCreateMapper = propertyCreateMapper;
	}

	public async Task AddAsync(PropertyCreateVM model)
	{
		await _propertyRepository.AddAsync(_propertyCreateMapper.GeneralConvertor(model));
	}

	public async Task SaveChangesAsync()
	{
		await _propertyRepository.SaveAsync();
	}
}
