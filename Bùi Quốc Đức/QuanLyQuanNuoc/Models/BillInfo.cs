//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyQuanNuoc.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BillInfo
    {
        public int id { get; set; }
        public int idBill { get; set; }
        public int idFood { get; set; }
        public Nullable<int> idDrink { get; set; }
        public double count { get; set; }
        public string idEmp { get; set; }
    
        public virtual Drink Drink { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Food Food { get; set; }
    }
}
