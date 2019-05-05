using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Customer.Models
{
    public class BookedTableEditViewModel
    {
        public int idTable { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerAddress { get; set; }
        public string BookDate { get; set; }
        public string BookTimeStart { get; set; }
        public string BookTimeEnd { get; set; }
    }
}
