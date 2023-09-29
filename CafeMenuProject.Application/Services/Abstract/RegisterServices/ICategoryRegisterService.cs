﻿using CafeMenuProject.Application.Services.Abstract.BaseServices;
using CafeMenuProject.ViewModel.Concrete.Create;

namespace CafeMenuProject.Application.Services.Abstract.RegisterServices;

/// <summary>
/// Interface representing a service for registering (adding) CategoryCreateVM entities.
/// Extends the base register service for CategoryCreateVM entities.
/// </summary>
public interface ICategoryRegisterService : IBaseRegisterService<CategoryCreateVM>
{
}
