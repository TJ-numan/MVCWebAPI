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
    
    public partial class tbl_group_life_premium_rate
    {
        public int id { get; set; }
        public string org_code { get; set; }
        public string plan_code { get; set; }
        public Nullable<decimal> life_premium_rate { get; set; }
        public Nullable<decimal> adb_premium_rate { get; set; }
        public Nullable<decimal> ppd_premium_rate { get; set; }
        public Nullable<decimal> ptd_premium_rate { get; set; }
        public Nullable<decimal> fpi_premium_rate { get; set; }
        public Nullable<decimal> festival_premium_rate { get; set; }
        public Nullable<decimal> others_premium_rate { get; set; }
        public string entry_by { get; set; }
        public Nullable<System.DateTime> entry_date { get; set; }
        public string updated_by { get; set; }
        public Nullable<System.DateTime> update_date { get; set; }
    }
}
