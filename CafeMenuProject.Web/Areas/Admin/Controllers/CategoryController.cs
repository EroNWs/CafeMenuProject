using CafeMenuProject.Application.Services.Abstract.DeleteServices;
using CafeMenuProject.Application.Services.Abstract.GetServices;
using CafeMenuProject.Application.Services.Abstract.RegisterServices;
using CafeMenuProject.Application.Services.Abstract.UpdateServices;
using CafeMenuProject.Utility.StaticDetails;
using CafeMenuProject.ViewModel.Concrete.Create;
using CafeMenuProject.ViewModel.Concrete.Get;
using CafeMenuProject.ViewModel.Concrete.Update;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CafeMenuProject.Web.Areas.Admin.Controllers;

/// <summary>
/// Controller handling operations related to categories in the admin area.
/// </summary>
[Area("Admin")]
[Authorize(Roles = StaticDetails.Role_Admin)]
public class CategoryController : Controller
{

	private readonly ICategoryRegisterService _categoryRegisterService;
	private readonly ICategoryGetService _categoryGetService;
	private readonly ICategoryDeleteService _categoryDeleteService;
	private readonly ICategoryUpdateService _categoryUpdateService;

	/// <summary>
	/// Initializes a new instance of the <see cref="CategoryController"/> class with the specified services.
	/// </summary>
	/// <param name="categoryRegisterService">The service for category registration.</param>
	/// <param name="categoryGetService">The service for retrieving category information.</param>
	/// <param name="categoryDeleteService">The service for category deletion.</param>
	/// <param name="categoryUpdateService">The service for category updates.</param>
	public CategoryController(ICategoryRegisterService categoryRegisterService, ICategoryGetService categoryGetService, ICategoryDeleteService categoryDeleteService, ICategoryUpdateService categoryUpdateService)
	{
		_categoryRegisterService = categoryRegisterService;
		_categoryGetService = categoryGetService;
		_categoryDeleteService = categoryDeleteService;
		_categoryUpdateService = categoryUpdateService;
	}

	/// <summary>
	/// Displays a list of categories.
	/// </summary>
	/// <returns>A view containing the list of categories.</returns>
	public async Task<IActionResult> Index()
	{
		var query = await _categoryGetService.GetAllAsync();
		return View(query);
	}

	/// <summary>
	/// Displays the form for creating a new category.
	/// </summary>
	/// <returns>A view containing the category creation form.</returns>
	public async Task<IActionResult> Create()
	{
		var categories = await _categoryGetService.GetAllAsync();
		var categorySelectListItems = categories.Select(c => new SelectListItem
		{
			Text = c.categoryName,
			Value = c.id.ToString(),
		}).ToList();


		ViewBag.Categories = categorySelectListItems;

		return View();
	}


	/// <summary>
	/// Handles the POST request for creating a new category.
	/// </summary>
	/// <param name="categoryCreateVM">The view model containing category information.</param>
	/// <returns>Redirects to the category list if successful, otherwise returns the category creation form.</returns>
	[HttpPost]
	public async Task<IActionResult> Create(CategoryCreateVM categoryCreateVM)
	{


		if (ModelState.IsValid)
		{
			await _categoryRegisterService.AddAsync(categoryCreateVM);
			await _categoryRegisterService.SaveChangesAsync();
			return RedirectToAction("Index");
		}

		return View();

	}



	/// <summary>
	/// Displays the form for editing a category.
	/// </summary>
	/// <param name="id">The ID of the category to be edited.</param>
	/// <returns>A view containing the category edit form.</returns>
	public IActionResult Edit(Guid? id)
	{
		if (id is null)
		{

			return NotFound();

		}

		CategoryGetVM categoryGetVM = _categoryGetService.Find(id.Value);

		return View(categoryGetVM);


	}

	/// <summary>
	/// Handles the POST request for updating a category.
	/// </summary>
	/// <param name="categoryUpdateVM">The view model containing updated category information.</param>
	/// <returns>Redirects to the category list if successful, otherwise returns the category edit form.</returns>
	[HttpPost]
	public async Task<IActionResult> Edit(CategoryUpdateVM categoryUpdateVM)
	{
		if (ModelState.IsValid)
		{
			_categoryUpdateService.Update(categoryUpdateVM);
			await _categoryUpdateService.SaveAsync();
			return RedirectToAction("Index");

		}

		return View();

	}


	public IActionResult Delete(Guid id)
	{
		if (id == null)
		{
			return NotFound();
		}

		CategoryGetVM categoryGetVM = _categoryGetService.Find(id);

		return View(categoryGetVM);


	}


	//[HttpPost, ActionName("Delete")]
	//public async Task<IActionResult> DeletePost(Guid id)
	//{

	//    CategoryUpdateVM categoryUpdateVM = _categoryUpdateService.Find(id);

	//    await _categoryUpdateService.Update(categoryDeleteVM);
	//    await _categoryUpdateService.SaveAsync();

	//    return RedirectToAction("Index");



	//}








}
