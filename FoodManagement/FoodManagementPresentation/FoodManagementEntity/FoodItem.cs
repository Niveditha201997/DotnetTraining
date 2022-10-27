using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FoodManagementEntity
{
    public class FoodItem
    {
        [Key] //primary key

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SINo { get; set; }

        [ForeignKey("FoodCategory")]
        public string FoodName { get; set; }
        public int CategoryId { get; set; }
        public FoodCategory foodCategory { get; set; }
    }
}
