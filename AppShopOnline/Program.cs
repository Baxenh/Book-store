using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using AppShopOnline.Areas.Identity.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("AppShopOnlineDbContextConnection") ?? throw new InvalidOperationException("Connection string 'AppShopOnlineDbContextConnection' not found.");

builder.Services.AddDbContext<AppShopOnlineDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<AppShopOnlineUser>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<AppShopOnlineDbContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

//Cấu hình sử  dụng Session
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(Options =>
{
    Options.IdleTimeout = TimeSpan.FromSeconds(60);
    Options.Cookie.HttpOnly = true;
    Options.Cookie.IsEssential = true;
    Options.Cookie.Name = ".Xenh.Sesion";
});

/////cấu hình trang
///
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();



//Sử dụng Session đã khai báo ở trên
app.UseSession();



app.UseRouting();






app.UseAuthorization();
app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Admin}/{action=Index}/{id?}");


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();
app.Run();
