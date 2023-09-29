using CafeMenuProject.Application.Services.Abstract.BaseServices;
using CafeMenuProject.Application.Services.Abstract.DeleteServices;
using CafeMenuProject.ViewModel.Concrete.Delete;

namespace CafeMenuProject.Application.Services.Concrete.DeleteServices;

public class ProductDeleteService : IProductDeleteService
{
	public void DeleteAsync(Guid id)
	{
		throw new NotImplementedException();
	}

	public ProductDeleteVM Find(Guid id)
	{
		throw new NotImplementedException();
	}

	public Task SaveAsync()
	{
		throw new NotImplementedException();
	}

	Task IBaseDeleteService<ProductDeleteVM>.DeleteAsync(Guid id)
	{
		throw new NotImplementedException();
	}
}
