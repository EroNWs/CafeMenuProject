using CafeMenuProject.ViewModel.Abstract;

namespace CafeMenuProject.ViewModel.Concrete.Create
{
	public class ProductCreateVM:IViewModel
	{
        public string ProductName { get; set; }
        public decimal Price { get; set; }

        public string? ImagePath { get; set; }

        public Guid CategoryId { get; set; }
    }
		
		
	

}
