using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Web.Customer.Data;

namespace Web.Customer.Models
{
    public class DrinkModel
    {
        [Key]
        public int idDrink { get; set; }
        [Display]
        public string name { get; set; }
        [Display]
        public int idCategoryDrink { get; set; }
        [Display]
        public int price { get; set; }
        [Display]
        public string image { get; set; }
        public Drink ToModel()
        {
            var op = new Drink
            {
                idDrink = idDrink,
                name = name,
                idCategoryDrink = idCategoryDrink,
                price = price,
                image = image,
            };
            return op;
        }

    }
}
