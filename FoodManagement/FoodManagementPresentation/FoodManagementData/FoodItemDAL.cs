using FoodManagementEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoodManagementData
{
    public class FoodItemDAL
    {
        FoodDbContext db = null;
        public string AddFoodItem(FoodItem foodItems)
        {
            db = new FoodDbContext();
            db.foodItems.Add(foodItems);
            db.SaveChanges();
            return "Saved";
        }
        public string UpdateFoodItem(FoodItem foodItem)
        {
            db = new FoodDbContext();
            db.Entry(foodItem).State = EntityState.Modified;
            db.SaveChanges();
            return "Updated";
        }
        public string DeleteFoodItem(int foodItemId)
        {
            db = new FoodDbContext();
            FoodItem obj = db.foodItems.Find(foodItemId);
            db.Entry(obj).State = EntityState.Deleted;
            db.SaveChanges();
            return "Deleted";
        }
        public List<FoodItem> ShowAll()
        {
            db = new FoodDbContext();
            List<FoodItem> foodItemList = db.foodItems.ToList();
            return foodItemList;
        }
        public List<FoodItem> ShowAllByFoodCategoryType(string type)
        {
            db = new FoodDbContext();
            List<FoodItem> foodItemList = db.foodItems.ToList();

            //Linq query-select * from movie where movietype = 'type'
            // var result = from FoodCategoryDAL in foodCategoryList
            // where foodCategories.foodCategoryType == type
            // select foo ;

            List<FoodItem> Result = new List<FoodItem>();
            // foreach (var item in result)
            // {
            // foodCategoryList.Add(item);
            // }
            return Result;
        }
        public FoodItem ShowFoodCategoryById(int foodItemId)
        {
            db = new FoodDbContext();
            FoodItem foodItem = db.foodItems.Find(foodItemId);
            return new FoodItem();
        }
    }
}
