using CafeMenuProject.Application.Services.Abstract.BaseServices;
using CafeMenuProject.ViewModel.Concrete.Get;

namespace CafeMenuProject.Application.Services.Abstract.GetServices;

/// <summary>
/// Interface representing a service for retrieving ProductGetVM entities.
/// Extends the base get service for ProductGetVM entities.
/// </summary>
public interface IProductGetService : IBaseGetService<ProductGetVM>
{
}
