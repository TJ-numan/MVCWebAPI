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
    
    public partial class tbl_ilb_adjusted_premium
    {
        public int id { get; set; }
        public string proposal_no { get; set; }
        public string pdab_diab { get; set; }
        public Nullable<decimal> pdab_diab_rate { get; set; }
        public Nullable<decimal> pdab_diab_premium { get; set; }
        public Nullable<decimal> total_premium { get; set; }
        public Nullable<decimal> oe_rate { get; set; }
        public Nullable<decimal> oe_premium { get; set; }
        public Nullable<decimal> em_rate { get; set; }
        public Nullable<decimal> em_premium { get; set; }
    }
}
