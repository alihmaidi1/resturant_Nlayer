using Microsoft.EntityFrameworkCore;
using RestaurantOrderProject.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderProject.DataAccessLayer.Concrete
{
    public class RestaurantOrderContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-47FTA5Q\\SQLEXPRESS;initial Catalog=RestaurantOrderDb;integrated Security=true");
            
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Category> Categories { get; set; }
       public DbSet<Contact> Contacts { get; set; }
       public DbSet<Discount> Discounts { get; set; }
       public DbSet<Feature> Features { get; set; }
       public DbSet<Product> Product { get; set; }
       public DbSet<SocialMedia> SocialMedias { get; set; }
       public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<MoneyCase> MoneyCases { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Notification> Notifications { get; set; }

    }
}
