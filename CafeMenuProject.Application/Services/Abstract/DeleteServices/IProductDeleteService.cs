using CafeMenuProject.Application.Services.Abstract.BaseServices;
using CafeMenuProject.ViewModel.Concrete.Delete;

namespace CafeMenuProject.Application.Services.Abstract.DeleteServices;

/// <summary>
/// Interface representing a service for deleting ProductDeleteVM entities.
/// Extends the base delete service for ProductDeleteVM entities.
/// </summary>
public interface IProductDeleteService:IBaseDeleteService<ProductDeleteVM>
{
}
