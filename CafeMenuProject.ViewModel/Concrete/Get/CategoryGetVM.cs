using CafeMenuProject.ViewModel.Abstract;

namespace CafeMenuProject.ViewModel.Concrete.Get
{
	public record CategoryGetVM(Guid id, string categoryName):IViewModel;
	
}
