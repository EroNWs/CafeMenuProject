using CafeMenuProject.Application.Repositories;
using CafeMenuProject.Persistence.Contexts;
using CafeMenuProject.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CafeMenuProject.Persistence.Registration;

/// <summary>
/// Provides extension methods for registering persistence services in the dependency injection container.
/// </summary>
public static class PersistenceServiceRegistration
{
	/// <summary>
	/// Adds persistence-related services to the dependency injection container.
	/// </summary>
	/// <param name="services">The collection of service descriptors.</param>
	/// <param name="configuration">The application configuration containing database connection settings.</param>
	/// <returns>The modified service collection.</returns>
	public static IServiceCollection AddPersistenceService(this IServiceCollection services, IConfiguration configuration)
	{

		services.AddDbContext<BaseDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("CafeMenu")));

		services.AddScoped<ICategoryRepository, CategoryRepository>();
		services.AddScoped<IProductRepository, ProductRepository>();
		services.AddScoped<IPropertyRepository, PropertyRepository>();

		return services;


	}



}
