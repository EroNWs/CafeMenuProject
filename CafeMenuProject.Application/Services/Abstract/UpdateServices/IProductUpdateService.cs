using CafeMenuProject.Application.Services.Abstract.BaseServices;
using CafeMenuProject.ViewModel.Concrete.Update;

namespace CafeMenuProject.Application.Services.Abstract.UpdateServices;

/// <summary>
/// Interface representing a service for updating ProductUpdateVM entities.
/// Extends the base update service for ProductUpdateVM entities.
/// </summary>
public interface IProductUpdateService : IBaseUpdateService<ProductUpdateVM>
{
}
