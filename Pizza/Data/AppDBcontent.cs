using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Pizza.Data.Models;

namespace Pizza.Data
{
    public class AppDBcontent : DbContext
    {
        public AppDBcontent(DbContextOptions<AppDBcontent> options) : base(options)
        {
        }

        public DbSet<Food> Food { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<PizzaCartItem> PizzaCartItem { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Admin> Admins { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    id = 1,
                    phone = "+380933613299",
                    email = "prijmakvlad7@gmail.com",
                    address = "Kyiv, Ukraine",
                    latitude = 50.4501,
                    longitude = 30.5234
                },
                new Contact
                {
                    id = 2,
                    phone = "+380970494450",
                    email = "andreyzet08a@icloud.com",
                    address = "Kyiv, Ukraine",
                    latitude = 50.4501,
                    longitude = 30.5234
                }
            );

            var hasher = new PasswordHasher<Admin>();

            var admin = new Admin
            {
                Id = 1,
                Login = "admin"
            };

            admin.PasswordHash = hasher.HashPassword(admin, "admin12345");

            modelBuilder.Entity<Admin>().HasData(admin);
        }
    }
}