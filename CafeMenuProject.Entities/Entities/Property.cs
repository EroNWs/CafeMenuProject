using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace CafeMenuProject.Domain.Entities;

/// <summary>
/// Represents a property entity with associated key-value pairs.
/// </summary>
public class Property
{
	/// <summary>
	/// Gets or sets the unique identifier for the property.
	/// </summary>
	public Guid Id { get; set; }

	/// <summary>
	/// Gets or sets the JSON representation of key-value pairs associated with the property.
	/// </summary>
	[JsonIgnore]
	public string KeyValuePairsJson { get; set; }

	/// <summary>
	/// Gets or sets the dictionary of key-value pairs associated with the property.
	/// </summary>
	[NotMapped]
	public Dictionary<string, string> KeyValuePairs
	{
		get => JsonConvert.DeserializeObject<Dictionary<string, string>>(KeyValuePairsJson)
			   ?? new Dictionary<string, string>(); // Returns an empty dictionary if JSON data is null
		set => KeyValuePairsJson = JsonConvert.SerializeObject(value);
	}

	/// <summary>
	/// Gets or sets the list of product-property associations related to this property.
	/// </summary>
	public List<ProductProperty> ProductProperties { get; set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="Property"/> class.
	/// </summary>
	public Property()
	{
		KeyValuePairs = new Dictionary<string, string>();
		ProductProperties = new List<ProductProperty>();
	}
}