using CafeMenuProject.Application.Services.Abstract.BaseServices;
using CafeMenuProject.ViewModel.Concrete.Create;

namespace CafeMenuProject.Application.Services.Abstract.RegisterServices;

/// <summary>
/// Interface representing a service for registering (adding) ProductCreateVM entities.
/// Extends the base register service for ProductCreateVM entities.
/// </summary>
public interface IProductRegisterService : IBaseRegisterService<ProductCreateVM>
{
}
