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
    
    public partial class tbl_ilb_stamp_purchase_master
    {
        public int id { get; set; }
        public Nullable<System.DateTime> purchase_date { get; set; }
        public string ref_no { get; set; }
        public Nullable<decimal> stamp_amt { get; set; }
        public string remarks { get; set; }
        public string userid { get; set; }
        public string payment_mode { get; set; }
        public string cq_no { get; set; }
        public Nullable<System.DateTime> cq_date { get; set; }
        public string bank_code { get; set; }
        public string branch_code { get; set; }
        public string deposite_bank { get; set; }
        public string updated_by { get; set; }
        public Nullable<System.DateTime> entry_date { get; set; }
    }
}
