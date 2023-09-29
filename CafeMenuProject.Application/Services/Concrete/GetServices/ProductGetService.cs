using CafeMenuProject.Application.Repositories;
using CafeMenuProject.Application.Services.Abstract.GetServices;
using CafeMenuProject.Mapper.Abstract.GetMapper;
using CafeMenuProject.ViewModel.Concrete.Get;

namespace CafeMenuProject.Application.Services.Concrete.GetServices;

public class ProductGetService : IProductGetService
{
	private readonly IProductRepository _productRepository;
	private readonly IProductGetMapper _productGetMapper;

	public ProductGetService(IProductRepository productRepository, IProductGetMapper productGetMapper)
	{
		_productRepository = productRepository;
		_productGetMapper = productGetMapper;
	}

	public ProductGetVM Find(Guid id)
	{
		var query = _productRepository.Find(id);
		var data = _productGetMapper.GeneralConvertor(query);
		return data;
	}


	public async Task<IEnumerable<ProductGetVM>> GetAllAsync()
	{
		var query = await _productRepository.GetAllAsync();
		List<ProductGetVM> productGetVMs = new List<ProductGetVM>();

		foreach (var item in query)
		{
			var productGetVM = _productGetMapper.GeneralConvertor(item);
			productGetVMs.Add(productGetVM);
		}

		return productGetVMs;
	}

	

}
