using CafeMenuProject.ViewModel.Abstract;

namespace CafeMenuProject.ViewModel.Concrete.Get
{
	public record ProductGetVM(Guid id, string productName, decimal price, string imagePath) : IViewModel;


}
