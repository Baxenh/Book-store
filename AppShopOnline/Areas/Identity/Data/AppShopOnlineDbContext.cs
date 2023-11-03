using AppShopOnline.Areas.Identity.Data;
using AppShopOnline.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AppShopOnline.Areas.Identity.Data;

public class AppShopOnlineDbContext : IdentityDbContext<AppShopOnlineUser>
{
    public AppShopOnlineDbContext(DbContextOptions<AppShopOnlineDbContext> options)
        : base(options)
    {
    }
    public virtual DbSet<Banner> Banners { get; set; }

    public virtual DbSet<Blog> Blogs { get; set; }

    public virtual DbSet<Cart1> Cart1s { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<CheckOut> CheckOuts { get; set; }

    public virtual DbSet<Contact> Contacts { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<New> News { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderDetail> Orderdetails { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Size> Sizes { get; set; }

    public virtual DbSet<Slider> Sliders { get; set; }
    public virtual DbSet<Share> Shares { get; set; }



    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }



    public DbSet<AppShopOnline.Models.Color> Color { get; set; }
}
