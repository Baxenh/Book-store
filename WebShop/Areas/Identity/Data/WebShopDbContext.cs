using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebShop.Areas.Identity.Data;
using WebShop.Models;

namespace WebShop.Areas.Identity.Data;

public class WebShopDbContext : IdentityDbContext<WebShopUserDBContext>
{
    public WebShopDbContext(DbContextOptions<WebShopDbContext> options)
        : base(options)


    { }

            public virtual DbSet<Banner> Banners { get; set; }

            public virtual DbSet<Blog> Blogs { get; set; }

             public virtual DbSet<Menu> Menus { get; set; }
            public virtual DbSet<Post> Posts { get; set; }
             public virtual DbSet<Category> Categorys { get; set; }

            public virtual DbSet<CheckOut> CheckOuts { get; set; }

            public virtual DbSet<Contact> Contacts { get; set; }

            public virtual DbSet<Customer> Customers { get; set; }

            public virtual DbSet<New> News { get; set; }

            public virtual DbSet<Order> Orders { get; set; }

            public virtual DbSet<OrderDedail> Orderdetails { get; set; }

            public virtual DbSet<Product> Products { get; set; }

            public virtual DbSet<Size> Sizes { get; set; }

            public virtual DbSet<Slider> Sliders { get; set; }
            public virtual DbSet<Share> Shares { get; set; }
            public virtual DbSet<User> Users { get; set; } 
            public virtual DbSet<Topic> Topics { get; set; }



}
