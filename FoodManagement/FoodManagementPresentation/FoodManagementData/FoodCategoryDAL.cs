using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FoodManagementEntity;

namespace FoodManagementData
{
    public class FoodCategoryDAL
    {
        FoodDbContext db = null;

        public string AddFoodCategory(FoodCategory foodCategories)
        {
            db = new FoodDbContext();
            db.foodCategories.Add(foodCategories);
            db.SaveChanges();
            return "Saved";
        }
        public string UpdateFoodCategory(FoodCategory foodCategories)
        {
            db = new FoodDbContext();
            db.Entry(foodCategories).State = EntityState.Modified;
            db.SaveChanges();
            return "Updated";
        }
        public string DeleteFoodCategory(int foodCategoryId)
        {
            db = new FoodDbContext();
            FoodCategory obj = db.foodCategories.Find(foodCategoryId);
            db.Entry(obj).State = EntityState.Deleted;
            db.SaveChanges();
            return "Deleted";
        }
        public List<FoodCategory> ShowAll()
        {
            db = new FoodDbContext();
            List<FoodCategory> foodCategoryList = db.foodCategories.ToList();
            return foodCategoryList;
        }
        public List<FoodCategory> ShowAllByFoodCategoryType(string type)
        {
            db = new FoodDbContext();
            List<FoodCategory> foodCategoryList = db.foodCategories.ToList();

            //Linq query-select * from movie where movietype = 'type'
           // var result = from FoodCategoryDAL in foodCategoryList
                        // where foodCategories.foodCategoryType == type
                        // select foo ;

            List<FoodCategory> Result = new List<FoodCategory>();
           // foreach (var item in result)
           // {
               // foodCategoryList.Add(item);
           // }
            return Result;
        }
        public FoodCategory ShowFoodCategoryById(int foodCategoriesId)
        {
            db = new FoodDbContext();
            FoodCategory foodCategory = db.foodCategories.Find(foodCategoriesId);
            return new FoodCategory();
        }
    }
}
