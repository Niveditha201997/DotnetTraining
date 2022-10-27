using FoodManagementEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoodManagementData
{
    public class FoodSalesDAL
    {
        FoodDbContext db = null;
        public string AddFoodSales(FoodSales Sales)
        {
            db = new FoodDbContext();
            db.foodSales.Add(Sales);
            db.SaveChanges();
            return "Saved";
        }
        public string UpdateFoodSales(FoodSales sales)
        {
            db = new FoodDbContext();
            db.Entry(sales).State = EntityState.Modified;
            db.SaveChanges();
            return "Updated";
        }
        public string DeleteFoodSales(int foodSalesId)
        {
            db = new FoodDbContext();
            FoodSales obj = db.foodSales.Find(foodSalesId);
            db.Entry(obj).State = EntityState.Deleted;
            db.SaveChanges();
            return "Deleted";
        }
        public List<FoodSales> ShowAll()
        {
            db = new FoodDbContext();
            List<FoodSales> foodSalesList = db.foodSales.ToList();
            return foodSalesList;
        }
        public List<FoodSales> ShowAllByFoodSalesType(string type)
        {
            db = new FoodDbContext();
            List<FoodSales> foodSalesList = db.foodSales.ToList();

            //Linq query-select * from movie where movietype = 'type'
            // var result = from FoodCategoryDAL in foodCategoryList
            // where foodCategories.foodCategoryType == type
            // select foo ;

            List<FoodSales> Result = new List<FoodSales>();
            // foreach (var item in result)
            // {
            // foodCategoryList.Add(item);
            // }
            return Result;
        }
        public FoodSales ShowFoodSalesById(int foodSalesId)
        {
            db = new FoodDbContext();
            FoodSales foodSales = db.foodSales.Find(foodSalesId);
            return new FoodSales();
        }
    }
}
