using CafeMenuProject.Domain.Abstract;

namespace CafeMenuProject.Domain.Entities;

/// <summary>
/// Represents a category entity with common properties inherited from <see cref="BaseEntity"/>.
/// </summary>
public class Category : BaseEntity
{
	/// <summary>
	/// Gets or sets the name of the category.
	/// </summary>
	public string CategoryName { get; set; }

	/// <summary>
	/// Gets or sets the unique identifier of the parent category.
	/// </summary>
	public Guid? ParentCategoryId { get; set; }

	/// <summary>
	/// Gets or sets the list of products associated with this category.
	/// </summary>
	public List<Product> Products { get; set; }

	/// <summary>
	/// Gets or sets the collection of subcategories under this category.
	/// </summary>
	public virtual ICollection<Category> InverseCategoryNavigation { get; } = new List<Category>();

	/// <summary>
	/// Gets or sets the parent category of this category.
	/// </summary>
	public virtual Category? CategoryNavigation { get; set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="Category"/> class.
	/// </summary>
	public Category()
	{
		Products = new List<Product>();
	}
}
