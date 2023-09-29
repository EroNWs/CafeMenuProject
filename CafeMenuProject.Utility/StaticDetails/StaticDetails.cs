using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenuProject.Utility.StaticDetails;

/// <summary>
/// A static class containing constant values used throughout the application.
/// </summary>
public static class StaticDetails
{
	/// <summary>
	/// Represents the role of a customer in the application.
	/// </summary>
	public const string Role_Customer = "Customer";

	/// <summary>
	/// Represents the role of an admin in the application.
	/// </summary>
	public const string Role_Admin = "Admin";

	/// <summary>
	/// Represents the status of an order as "Pending."
	/// </summary>
	public const string StatusPending = "Pending";

	/// <summary>
	/// Represents the status of an order as "Approved."
	/// </summary>
	public const string StatusApproved = "Approved";

	/// <summary>
	/// Represents the status of an order as "In Process" or "Processing."
	/// </summary>
	public const string StatusInProcess = "Processing";

	/// <summary>
	/// Represents the status of an order as "Cancelled."
	/// </summary>
	public const string StatusCancelled = "Cancelled";


}