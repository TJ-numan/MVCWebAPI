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
    
    public partial class tbl_group_premium_claim_summary
    {
        public int premium_claim_summary_id { get; set; }
        public string org_code { get; set; }
        public Nullable<System.DateTime> cycle_start_date { get; set; }
        public Nullable<System.DateTime> cycle_end_date { get; set; }
        public Nullable<decimal> health_premium_received { get; set; }
        public Nullable<decimal> health_claim_paid { get; set; }
        public Nullable<decimal> life_premium_received { get; set; }
        public Nullable<decimal> life_claim_paid { get; set; }
        public Nullable<decimal> summary_status { get; set; }
        public Nullable<System.DateTime> entry_date { get; set; }
        public Nullable<decimal> health_claim_count { get; set; }
        public Nullable<decimal> life_claim_count { get; set; }
        public byte profit_is_shared { get; set; }
        public decimal shared_profit_amount { get; set; }
    }
}
