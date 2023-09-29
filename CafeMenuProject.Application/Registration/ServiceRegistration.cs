using CafeMenuProject.Application.Services.Abstract.DeleteServices;
using CafeMenuProject.Application.Services.Abstract.GetServices;
using CafeMenuProject.Application.Services.Abstract.RegisterServices;
using CafeMenuProject.Application.Services.Abstract.UpdateServices;
using CafeMenuProject.Application.Services.Concrete.DeleteServices;
using CafeMenuProject.Application.Services.Concrete.GetServices;
using CafeMenuProject.Application.Services.Concrete.RegisterServices;
using CafeMenuProject.Application.Services.Concrete.Updateservices;
using CafeMenuProject.Mapper.Abstract.CreateMapper;
using CafeMenuProject.Mapper.Abstract.DeleteMapper;
using CafeMenuProject.Mapper.Abstract.GetMapper;
using CafeMenuProject.Mapper.Abstract.UpdateMapper;
using CafeMenuProject.Mapper.CreateMapper;
using CafeMenuProject.Mapper.DeleteMapper;
using CafeMenuProject.Mapper.GetMapper;
using CafeMenuProject.Mapper.UpdateMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CafeMenuProject.Application.Registration;

/// <summary>
/// Class responsible for registering application services and mappers in the dependency injection container.
/// </summary>
public static class ServiceRegistration
{
	/// <summary>
	/// Adds application services and mappers to the specified <see cref="IServiceCollection"/>.
	/// </summary>
	/// <param name="services">The <see cref="IServiceCollection"/> to which the services and mappers will be added.</param>
	/// <param name="configuration">The <see cref="IConfiguration"/> instance for configuring services.</param>
	/// <returns>The modified <see cref="IServiceCollection"/> with added services and mappers.</returns>
	public static IServiceCollection AddServiceRegistration(this IServiceCollection services, IConfiguration configuration)
	{
		services.AddScoped<ICategoryGetService, CategoryGetService>();
		services.AddScoped<ICategoryDeleteService, CategoryDeleteService>();
		services.AddScoped<ICategoryUpdateService, CategoryUpdateService>();
		services.AddScoped<ICategoryRegisterService, CategoryRegisterService>();

		services.AddScoped<IProductGetService, ProductGetService>();
		services.AddScoped<IProductDeleteService, ProductDeleteService>();
		services.AddScoped<IProductUpdateService, ProductUpdateService>();
		services.AddScoped<IProductRegisterService, ProductRegisterService>();

		services.AddScoped<IPropertyRegisterService, PropertyRegisterService>();

		services.AddScoped<ICategoryCreateMapper, CategoryCreateMapper>();
		services.AddScoped<ICategoryDeleteMapper, CategoryDeleteMapper>();
		services.AddScoped<ICategoryUpdateMapper, CategoryUpdateMapper>();
		services.AddScoped<ICategoryGetMapper, CategoryGetMapper>();

		services.AddScoped<IProductCreateMapper, ProductCreateMapper>();
		services.AddScoped<IProductDeleteMapper, ProductDeleteMapper>();
		services.AddScoped<IProductUpdateMapper, ProductUpdateMapper>();
		services.AddScoped<IProductGetMapper, ProductGetMapper>();

		services.AddScoped<IPropertyGetMapper, PropertyGetMapper>();
		services.AddScoped<IPropertyDeleteMapper, PropertyDeleteMapper>();
		services.AddScoped<IPropertyUpdateMapper, PropertyUpdateMapper>();
		services.AddScoped<IPropertyCreateMapper, PropertyCreateMapper>();

		return services;


	}



}