using CafeMenuProject.Domain.Abstract;

namespace CafeMenuProject.Domain.Entities;

/// <summary>
/// Represents a product entity with common properties inherited from <see cref="BaseEntity"/>.
/// </summary>
public class Product : BaseEntity
{
	/// <summary>
	/// Gets or sets the name of the product.
	/// </summary>
	public string ProductName { get; set; }

	/// <summary>
	/// Gets or sets the price of the product.
	/// </summary>
	public decimal Price { get; set; }

	/// <summary>
	/// Gets or sets the file path of the product's image.
	/// </summary>
	public string ImagePath { get; set; }

	/// <summary>
	/// Gets or sets the unique identifier of the category to which the product belongs.
	/// </summary>
	public Guid? CategoryId { get; set; }

	/// <summary>
	/// Gets or sets the category to which the product belongs.
	/// </summary>
	public Category? Category { get; set; }

	/// <summary>
	/// Gets or sets the list of properties associated with this product.
	/// </summary>
	public List<ProductProperty> ProductProperties { get; set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="Product"/> class.
	/// </summary>
	public Product()
	{
		ProductProperties = new List<ProductProperty>();
	}
}
