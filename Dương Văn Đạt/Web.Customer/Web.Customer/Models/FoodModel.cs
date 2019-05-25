using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Web.Customer.Data;

namespace Web.Customer.Models
{
    public class FoodModel
    {
        [Key]
        public int idFood { get; set; }
        [Display]
        public string Name { get; set; }
        [Display]
        public int idCategoryFood { get; set; }
        [Display]
        public int price { get; set; }
        [Display]
        public string image { get; set; }
        public Food ToModel()
        {
            var op = new Food
            {
                idFood = idFood,
                name = Name,
                idCategoryFood = idCategoryFood,
                price = price,
                image = image,
            };
            return op;
        }

    }
}
