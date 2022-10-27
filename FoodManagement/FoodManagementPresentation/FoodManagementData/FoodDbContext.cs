using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using FoodManagementEntity;

namespace FoodManagementData
{
    public class FoodDbContext : Microsoft.EntityFrameworkCore.DbContext    
    {
        public DbSet<Admin> admins { get; set; }
        public DbSet<FoodCategory> foodCategories { get; set; }
        public DbSet<FoodItem> foodItems { get; set; }
        public DbSet<FoodSales> foodSales { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("Data source=VDC01LTC2013;Initial Catalog=FoodManagementProjectDb; Integrated Security=True;");
        }
    }
}
