using CafeMenuProject.ViewModel.Concrete.Currency;

namespace CafeMenuProject.ViewModel.Concrete.Get;

public class MainPageViewModel
{
	public CurrencyViewModel CurrencyData { get; set; }
	public IEnumerable<CategoryNameWithProductCountGetVM> CategoriesWithProductCount { get; set; }

}
