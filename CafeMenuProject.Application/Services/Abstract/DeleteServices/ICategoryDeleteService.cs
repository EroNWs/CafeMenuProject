using CafeMenuProject.Application.Services.Abstract.BaseServices;
using CafeMenuProject.ViewModel.Concrete.Delete;

namespace CafeMenuProject.Application.Services.Abstract.DeleteServices;

/// <summary>
/// Interface representing a service for deleting CategoryDeleteVM entities.
/// Extends the base delete service for CategoryDeleteVM entities.
/// </summary>
public interface ICategoryDeleteService:IBaseDeleteService<CategoryDeleteVM>
{

}
