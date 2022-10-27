using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FoodManagementEntity
{
    public class FoodSales
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SalesId { get; set; }
        public string CustomerName { get; set; }
        public string status { get; set; }

        [ForeignKey("FoodCategory")]
        public int CategoryId { get; set; }
        public string FoodName { get; set; }
        public FoodCategory foodCategory { get; set; }
    }
}
