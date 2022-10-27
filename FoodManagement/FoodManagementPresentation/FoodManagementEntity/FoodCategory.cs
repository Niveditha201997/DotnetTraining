using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodManagementEntity
{
    public class FoodCategory
    {
        List<FoodCategory> foodCategories = null;

        [Key] 

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int CategoryId { get; set; }
        public string FoodName { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
    }
}
