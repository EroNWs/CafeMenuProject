using CafeMenuProject.Application.Registration;
using CafeMenuProject.Persistence.Contexts;
using CafeMenuProject.Persistence.Registration;
using CafeMenuProject.Utility;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services
	.AddControllersWithViews();

builder.Services
	.AddPersistenceService(builder.Configuration);

builder.Services
	.AddServiceRegistration(builder.Configuration);



builder.Services.AddIdentity<IdentityUser, IdentityRole>()
	.AddEntityFrameworkStores<BaseDbContext>()
	.AddDefaultTokenProviders();


builder.Services.ConfigureApplicationCookie(options =>
{
	options.LoginPath = $"/Identity/Account/Login";
	options.LogoutPath = $"/Identity/Account/Logout";
	options.AccessDeniedPath = $"/Identity/Account/AccessDenied";
});


builder.Services
.AddRazorPages();



builder.Services
	.AddScoped<IEmailSender, EmailSender>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseMigrationsEndPoint();
}
else
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();
app.MapRazorPages();
app.MapControllerRoute(
	name: "default",
	pattern: "{area=Customer}/{controller=Home}/{action=Index}/{id?}");


app.Run();
