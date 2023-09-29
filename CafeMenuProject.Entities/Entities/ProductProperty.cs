namespace CafeMenuProject.Domain.Entities;

/// <summary>
/// Represents a link between products and their associated properties.
/// </summary>
public class ProductProperty
{
	/// <summary>
	/// Gets or sets the unique identifier for the product-property association.
	/// </summary>
	public Guid ProductPropertyId { get; set; }

	/// <summary>
	/// Gets or sets the unique identifier of the product.
	/// </summary>
	public Guid ProductId { get; set; }

	/// <summary>
	/// Gets or sets the unique identifier of the property.
	/// </summary>
	public Guid PropertyId { get; set; }

	/// <summary>
	/// Gets or sets the product associated with this product-property link.
	/// </summary>
	public Product? Product { get; set; }

	/// <summary>
	/// Gets or sets the property associated with this product-property link.
	/// </summary>
	public Property? Property { get; set; }
}
