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
    
    public partial class tbl_ilb_policy_SB_master
    {
        public int id { get; set; }
        public string policy_no { get; set; }
        public string installment_no { get; set; }
        public Nullable<decimal> sb_amount { get; set; }
        public Nullable<System.DateTime> sb_date { get; set; }
        public string status { get; set; }
        public string bank_ac_name { get; set; }
        public string bank_ac_no { get; set; }
        public string bank_name { get; set; }
        public string bank_branch_name { get; set; }
        public string bank_routing_no { get; set; }
        public Nullable<System.DateTime> payment_date { get; set; }
        public string payment_mode { get; set; }
        public string payment_details { get; set; }
        public string bill_ref_no { get; set; }
        public string dis_voucher_doc { get; set; }
        public string entry_by { get; set; }
        public Nullable<System.DateTime> entry_date { get; set; }
        public string update_by { get; set; }
        public Nullable<System.DateTime> update_date { get; set; }
    }
}
