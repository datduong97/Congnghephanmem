﻿//------------------------------------------------------------------------------
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
    using System.ComponentModel.DataAnnotations;

    public partial class BookedTable
    {
        public int id { get; set; }
        [Required]
        public Nullable<int> idTable { get; set; }
        [Display(Name = "Tên khách hàng")]
        [Required]
        public string CustomerName { get; set; }
        [Display(Name = "Số điện thoại")]
        [Required]
        public string CustomerPhone { get; set; }
        [Display(Name = "Địa chỉ")]
        [Required]
        public string CustomerAddress { get; set; }
        [Display(Name = "Ngày đặt bàn")]
        [Required]
        public string BookDate { get; set; }
        [Display(Name = "Thời gian đặt")]
        public string BookTimeStart { get; set; }
        [Display(Name = "Thời gian kết thúc")]
        [Required]
        public string BookTimeEnd { get; set; }
    
        public virtual Table Table { get; set; }
        public virtual Table Table1 { get; set; }
    }
}
