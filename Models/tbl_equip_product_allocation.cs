//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace myWebAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_equip_product_allocation
    {
        public int id { get; set; }
        public Nullable<int> dept_id { get; set; }
        public string producer_id { get; set; }
        public string allocate_to { get; set; }
        public Nullable<int> product_id { get; set; }
        public string product_name { get; set; }
        public string imei_number { get; set; }
        public Nullable<int> quantity { get; set; }
        public Nullable<int> emi_flag { get; set; }
        public Nullable<decimal> total_cost { get; set; }
        public Nullable<System.DateTime> entry_date { get; set; }
        public Nullable<int> emi_term { get; set; }
        public Nullable<decimal> emi_amount { get; set; }
        public Nullable<int> preferable_date { get; set; }
    }
}
