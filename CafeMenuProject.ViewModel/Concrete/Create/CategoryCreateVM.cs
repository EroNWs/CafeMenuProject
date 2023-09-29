using CafeMenuProject.ViewModel.Abstract;

namespace CafeMenuProject.ViewModel.Concrete.Create
{
	public class CategoryCreateVM:IViewModel
	{
        public string CategoryName { get; set; }

		public Guid? ParentCategoryId { get; set; }


	}
}
