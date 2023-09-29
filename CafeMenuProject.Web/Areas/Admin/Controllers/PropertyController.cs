using CafeMenuProject.Application.Services.Abstract.RegisterServices;
using CafeMenuProject.Utility.StaticDetails;
using CafeMenuProject.ViewModel.Concrete.Create;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CafeMenuProject.Web.Areas.Admin.Controllers;

/// <summary>
/// Controller handling operations related to properties in the admin area.
/// </summary>
[Area("Admin")]
[Authorize(Roles = StaticDetails.Role_Admin)]
public class PropertyController : Controller
{

	private readonly IPropertyRegisterService _propertyRegisterService;

	/// <summary>
	/// Initializes a new instance of the <see cref="PropertyController"/> class with the specified service.
	/// </summary>
	/// <param name="propertyRegisterService">The service for property registration.</param>
	public PropertyController(IPropertyRegisterService propertyRegisterService)
	{
		_propertyRegisterService = propertyRegisterService;
	}

	/// <summary>
	/// Displays a list of properties.
	/// </summary>
	/// <returns>A view containing a list of properties.</returns>
	public IActionResult Index()
	{
		return View();
	}

	/// <summary>
	/// Displays the property creation form.
	/// </summary>
	/// <returns>A view for creating a new property.</returns>
	public IActionResult Create()
	{
		return View();
	}

	/// <summary>
	/// Handles the property creation form submission.
	/// </summary>
	/// <param name="propertyCreateVM">The view model containing property data.</param>
	/// <returns>A redirection to the property list page if successful, otherwise the creation form.</returns>
	[HttpPost]
	public async Task<IActionResult> Create(PropertyCreateVM propertyCreateVM)
	{


		if (ModelState.IsValid)
		{
			await _propertyRegisterService.AddAsync(propertyCreateVM);
			await _propertyRegisterService.SaveChangesAsync();
			return RedirectToAction("Index");
		}

		return View();

	}






}
