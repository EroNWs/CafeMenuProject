using CafeMenuProject.Application.Services.Abstract.BaseServices;
using CafeMenuProject.Application.Services.Abstract.DeleteServices;
using CafeMenuProject.ViewModel.Concrete.Delete;

namespace CafeMenuProject.Application.Services.Concrete.DeleteServices;

public class CategoryDeleteService : ICategoryDeleteService
{
	public void DeleteAsync(Guid id)
	{
		throw new NotImplementedException();
	}

	public CategoryDeleteVM Find(Guid id)
	{
		throw new NotImplementedException();
	}

	public Task SaveAsync()
	{
		throw new NotImplementedException();
	}

	Task IBaseDeleteService<CategoryDeleteVM>.DeleteAsync(Guid id)
	{
		throw new NotImplementedException();
	}
}
