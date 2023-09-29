using CafeMenuProject.Application.Services.Abstract.GetServices;
using CafeMenuProject.Utility.StaticDetails;
using CafeMenuProject.ViewModel.Concrete.Currency;
using CafeMenuProject.ViewModel.Concrete.Get;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Xml;

namespace CafeMenuProject.Web.Areas.Admin.Controllers
{

	/// <summary>
	/// Controller handling operations related to the main page in the admin area.
	/// </summary>
	[Area("Admin")]
	[Authorize(Roles = StaticDetails.Role_Admin)]
	public class MainPageController : Controller
	{
		private readonly ICategoryGetService _categoryGetService;

		/// <summary>
		/// Initializes a new instance of the <see cref="MainPageController"/> class with the specified category service.
		/// </summary>
		/// <param name="categoryGetService">The service for retrieving category information.</param>
		public MainPageController(ICategoryGetService categoryGetService)
		{
			_categoryGetService = categoryGetService;
		}

		/// <summary>
		/// Displays the main page with currency and category information.
		/// </summary>
		/// <returns>A view containing currency and category data.</returns>
		public async Task<IActionResult> MainPage()
		{

			XmlDocument xdom = new XmlDocument();
			xdom.Load("https://www.tcmb.gov.tr/kurlar/today.xml");
			XmlNode kur = xdom;
			string time;
			string usd;
			string euro;


			time = kur.SelectSingleNode("/Tarih_Date/@Tarih").InnerText;
			usd = kur.SelectSingleNode("/Tarih_Date/Currency[@Kod='USD']/ForexBuying").InnerText;
			euro = kur.SelectSingleNode("/Tarih_Date/Currency[@Kod='EUR']/ForexBuying").InnerText;

			var currencyModel = new CurrencyViewModel
			{
				Time = time,
				Usd = usd,
				Euro = euro
			};

			var categoriesWithProductCount = await _categoryGetService.GetCategoriesWithProductCount();

			var viewModel = new MainPageViewModel
			{
				CurrencyData = currencyModel,
				CategoriesWithProductCount = categoriesWithProductCount
			};

			return View(viewModel);



		}



	}
}
