using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenuProject.Utility;

/// <summary>
/// An email sender implementation that does not actually send emails (for testing and development purposes).
/// </summary>
public class EmailSender : IEmailSender
{
	/// <summary>
	/// Sends an email asynchronously.
	/// </summary>
	/// <param name="email">The recipient's email address.</param>
	/// <param name="subject">The subject of the email.</param>
	/// <param name="htmlMessage">The HTML content of the email.</param>
	/// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
	public Task SendEmailAsync(string email, string subject, string htmlMessage)
	{
		// This implementation does not actually send emails and completes the task immediately.
		return Task.CompletedTask;

	}

}
