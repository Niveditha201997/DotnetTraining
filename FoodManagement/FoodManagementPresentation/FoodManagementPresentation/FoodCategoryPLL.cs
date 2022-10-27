using System;
using System.Collections.Generic;
using System.Text;
using FoodManagementData;
using FoodManagementEntity;

namespace FoodManagementPresentation
{
    public class FoodCategoryPLL
    {
        public void AddFoodCategory()
        {
            FoodCategoryDAL foodCategoryDAL = new FoodCategoryDAL();
            FoodCategory foodCategory = new FoodCategory();
            //Console.WriteLine("Enter FoodCategory : ");
            //foodCategory.CategoryId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter MovieName : ");
            foodCategory.f = Console.ReadLine();
            Console.WriteLine("Enter Movie Type : ");
            movie.MovieType = Console.ReadLine();
            string msg = movieOperations.AddMovie(movie);
            Console.WriteLine(msg);
        }   
    }
}
