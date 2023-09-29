using Microsoft.AspNetCore.Identity;

namespace CafeMenuProject.Domain.Entities;

/// <summary>
/// Represents a user entity in the application, derived from IdentityUser class.
/// </summary>
public class User : IdentityUser
{
	/// <summary>
	/// Gets or sets the user's first name.
	/// </summary>
	public string Name { get; set; }

	/// <summary>
	/// Gets or sets the user's last name.
	/// </summary>
	public string Surname { get; set; }

	/// <summary>
	/// Gets or sets the user's role within the application.
	/// </summary>
	public string Role { get; set; }
}