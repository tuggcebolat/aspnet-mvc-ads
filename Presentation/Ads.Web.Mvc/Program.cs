using Microsoft.AspNetCore.Authentication.Cookies;
using Ads.Application.Services;
using Ads.Persistence;
using Ads.Persistence.Contexts;
using Ads.Persistence.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddPersistenceServices();

//builder.Services.AddDbContext<AppDbContext>();

//builder.Services.AddTransient(typeof(IService<>), typeof(Service<>));
//builder.Services.AddTransient<IAdvertService, AdvertService>();
//builder.Services.AddTransient<IUserService, UserService>();
//builder.Services.AddTransient<ICategoryService, CategoryService>();
//builder.Services.AddTransient<ISubCategoryService, SubCategoryService>();
//builder.Services.AddTransient<ISettingService, SettingService>();
//builder.Services.AddTransient<IAdvertCommentService, AdvertCommentService>();
//builder.Services.AddTransient<IAdvertImageService, AdvertImageService>();
//builder.Services.AddTransient<IAdvertRatingService, AdvertRatingService>();


builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(x =>
{
    x.LoginPath = "/Admin/Login"; //--> "/Account/Login";
    x.AccessDeniedPath = "/AccessDenied";
    x.LogoutPath = "/Admin/Logout"; //--> "/Account/Logout";
    x.Cookie.Name = "Admin";
    x.Cookie.MaxAge = TimeSpan.FromDays(7);
    x.Cookie.IsEssential = true;
});

builder.Services.AddAuthorization(x =>
{
    x.AddPolicy("AdminPolicy", policy => policy.RequireClaim("Role", "Admin"));
    x.AddPolicy("UserPolicy", policy => policy.RequireClaim("Role", "User"));

    //x.AddPolicy("AdminPolicy", policy => policy.RequireClaim(ClaimTypes.Role, "Admin"));
    //x.AddPolicy("UserPolicy", policy => policy.RequireClaim(ClaimTypes.Role, "Admin", "User"));
    //x.AddPolicy("CustomerPolicy", policy => policy.RequireClaim(ClaimTypes.Role, "Admin", "User", "Customer"));
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
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

app.MapControllerRoute(
            name: "admin",
            pattern: "{area:exists}/{controller=Main}/{action=Index}/{id?}"
          );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
