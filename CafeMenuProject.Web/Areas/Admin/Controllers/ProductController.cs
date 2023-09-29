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
/// Controller handling operations related to products in the admin area.
/// </summary>
[Area("Admin")]
[Authorize(Roles = StaticDetails.Role_Admin)]
[Area("Admin")]
[Authorize(Roles = StaticDetails.Role_Admin)]
public class ProductController : Controller
{
	private readonly IProductRegisterService _productRegisterService;
	private readonly IProductGetService _productGetService;
	private readonly ICategoryGetService _categoryGetService;
	private readonly IProductUpdateService _productUpdateService;
	private readonly IProductDeleteService _productDeleteService;

	/// <summary>
	/// Initializes a new instance of the <see cref="ProductController"/> class with the specified services.
	/// </summary>
	/// <param name="productRegisterService">The service for product registration.</param>
	/// <param name="productGetService">The service for retrieving product information.</param>
	/// <param name="categoryGetService">The service for retrieving category information.</param>
	/// <param name="productUpdateService">The service for product updates.</param>
	/// <param name="productDeleteService">The service for product deletion.</param>
	public ProductController(IProductRegisterService productRegisterService, IProductGetService productGetService, ICategoryGetService categoryGetService, IProductUpdateService productUpdateService, IProductDeleteService productDeleteService)
	{
		_productRegisterService = productRegisterService;
		_productGetService = productGetService;
		_categoryGetService = categoryGetService;
		_productUpdateService = productUpdateService;
		_productDeleteService = productDeleteService;
	}

	/// <summary>
	/// Displays a list of products.
	/// </summary>
	/// <returns>A view containing a list of products.</returns>
	public async Task<IActionResult> Index()
	{
		var query = await _productGetService.GetAllAsync();
		return View(query);
	}

	/// <summary>
	/// Displays the product creation form.
	/// </summary>
	/// <returns>A view for creating a new product.</returns>
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
	/// Handles the product creation form submission.
	/// </summary>
	/// <param name="productCreateVM">The view model containing product data.</param>
	/// <param name="file">The product image file.</param>
	/// <returns>A redirection to the product list page if successful, otherwise the creation form.</returns>
	[HttpPost]
	public async Task<IActionResult> Create(ProductCreateVM productCreateVM, IFormFile file)
	{


		if (ModelState.IsValid)
		{
			string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", file.FileName);

			using (var stream = new FileStream(path, FileMode.Create))
			{
				await file.CopyToAsync(stream);
			}

			productCreateVM.ImagePath = string.Concat("/images/", file.FileName);


			await _productRegisterService.AddAsync(productCreateVM);
			await _productRegisterService.SaveChangesAsync();
			return RedirectToAction("Index");
		}

		return View();

	}

	/// <summary>
	/// Displays the product edit form.
	/// </summary>
	/// <param name="id">The ID of the product to edit.</param>
	/// <returns>A view for editing the selected product.</returns>
	public IActionResult Edit(Guid? id)
	{
		if (id is null)
		{

			return NotFound();

		}

		ProductGetVM productGetVM = _productGetService.Find(id.Value);

		return View(productGetVM);


	}


	/// <summary>
	/// Handles the product edit form submission.
	/// </summary>
	/// <param name="productUpdateVM">The view model containing updated product data.</param>
	/// <returns>A redirection to the product list page if successful, otherwise the edit form.</returns>
	[HttpPost]
	public async Task<IActionResult> Edit(ProductUpdateVM productUpdateVM)
	{
		if (ModelState.IsValid)
		{
			_productUpdateService.Update(productUpdateVM);
			await _productUpdateService.SaveAsync();
			return RedirectToAction("Index");

		}

		return View();

	}

	/// <summary>
	/// Displays the product deletion confirmation page.
	/// </summary>
	/// <param name="id">The ID of the product to delete.</param>
	/// <returns>A view for confirming the deletion of the selected product.</returns>
	public IActionResult Delete(Guid id)
	{
		if (id == null)
		{
			return NotFound();
		}

		ProductGetVM productGetVM = _productGetService.Find(id);

		return View(productGetVM);


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
