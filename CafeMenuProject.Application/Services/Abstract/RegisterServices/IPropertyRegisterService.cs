using CafeMenuProject.Application.Services.Abstract.BaseServices;
using CafeMenuProject.ViewModel.Concrete.Create;

namespace CafeMenuProject.Application.Services.Abstract.RegisterServices;

/// <summary>
/// Interface representing a service for registering (adding) PropertyCreateVM entities.
/// Extends the base register service for PropertyCreateVM entities.
/// </summary>
public interface IPropertyRegisterService : IBaseRegisterService<PropertyCreateVM>
{
}
