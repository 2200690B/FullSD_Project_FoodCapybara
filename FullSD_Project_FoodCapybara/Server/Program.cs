using FullSD_Project_FoodCapybara.Server.Data;
using FullSD_Project_FoodCapybara.Server.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using FullSD_Project_FoodCapybara.Server.IRepository;
using FullSD_Project_FoodCapybara.Server.Repository;
using System.Text.Json.Serialization;
// controller can make use of the Unit of Work after registration

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// verify the email after registering by sending confirmation. put as false for now (options.SignIn.RequireConfirmedAccount = false)
builder.Services.AddDefaultIdentity<ApplicationUser>(options => 
options.SignIn.RequireConfirmedAccount = false)
     .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddIdentityServer()
    .AddApiAuthorization<ApplicationUser, ApplicationDbContext>(options =>{
        // Add the "role" claim to the identity token using IdentityServer
        options.IdentityResources["openid"].UserClaims.Add("role");
        // Add the "role" claim to the API access token using IdentityServer
        options.ApiResources.Single().UserClaims.Add("role");
    }); // this adds "role" claim to both the identity token and the API access token
        // make authorization decisions based on the user's roles.

builder.Services.AddAuthentication()
    .AddIdentityServerJwt();

// line 16-23 is all about authentication

builder.Services.AddTransient<IUnitOfWork, UnitOfWork>(); // to register the Unit of Work service in pogram.cs file
// do this before refactoring RestaurantController to use UnitOfWork framework of pattern

// to remove cycles like restaurants and foods
//builder.Services.AddControllersWithViews()
//                .AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
builder.Services.AddControllersWithViews().AddNewtonsoftJson(op =>
    op.SerializerSettings.ReferenceLoopHandling =
    Newtonsoft.Json.ReferenceLoopHandling.Ignore);


builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();

app.UseIdentityServer();
app.UseAuthorization();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
