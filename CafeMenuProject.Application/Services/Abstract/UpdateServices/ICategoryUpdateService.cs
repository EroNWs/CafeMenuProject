using CafeMenuProject.Application.Services.Abstract.BaseServices;
using CafeMenuProject.ViewModel.Concrete.Update;

namespace CafeMenuProject.Application.Services.Abstract.UpdateServices;

/// <summary>
/// Interface representing a service for updating CategoryUpdateVM entities.
/// Extends the base update service for CategoryUpdateVM entities.
/// </summary>
public interface ICategoryUpdateService : IBaseUpdateService<CategoryUpdateVM>
{
}
