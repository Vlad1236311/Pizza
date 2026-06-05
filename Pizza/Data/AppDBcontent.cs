using Pizza.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;



namespace Pizza.Data {
    public class AppDBcontent : DbContext
    {

        public AppDBcontent(DbContextOptions<AppDBcontent> options) : base(options)
        {

        }

        public DbSet<Food> Food { get; set; }
        public DbSet<Category> Category { get; set; }


    }
}
