using CafeMenuProject.Application.Repositories;
using CafeMenuProject.Application.Services.Abstract.RegisterServices;
using CafeMenuProject.Mapper.Abstract.CreateMapper;
using CafeMenuProject.ViewModel.Concrete.Create;

namespace CafeMenuProject.Application.Services.Concrete.RegisterServices;

public class ProductRegisterService : IProductRegisterService
{
	private readonly IProductRepository _productRepository;
	private readonly IProductCreateMapper _productCreateMapper;

	public ProductRegisterService(IProductRepository productRepository, IProductCreateMapper productCreateMapper)
	{
		_productRepository = productRepository;
		_productCreateMapper = productCreateMapper;
	}

	public async Task AddAsync(ProductCreateVM model)
	{
		await _productRepository.AddAsync(_productCreateMapper.GeneralConvertor(model));
	}

	public async Task SaveChangesAsync()
	{
		await _productRepository.SaveAsync();
	}
}
