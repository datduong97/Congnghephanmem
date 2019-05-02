using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Customer.Data;
using System.ComponentModel.DataAnnotations;

namespace Web.Customer.Models
{
    public class TableViewModel
    {
       
        public int Id { get; set; }
        [Display]
        public string name { get; set; }
        [Display]
        public bool status { get; set; }
    }
}
