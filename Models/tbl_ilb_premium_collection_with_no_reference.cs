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
    
    public partial class tbl_ilb_premium_collection_with_no_reference
    {
        public int id { get; set; }
        public string collection_ref_no { get; set; }
        public string policy_no { get; set; }
        public string form_no { get; set; }
        public string proposal_no { get; set; }
        public string payment_type { get; set; }
        public string collection_type { get; set; }
        public Nullable<double> collected_amount { get; set; }
        public Nullable<System.DateTime> payment_date { get; set; }
        public string cq_no { get; set; }
        public Nullable<System.DateTime> cq_date { get; set; }
        public Nullable<int> bank_code { get; set; }
        public Nullable<int> bank_branch_code { get; set; }
        public string mbank_refno { get; set; }
        public Nullable<System.DateTime> mbank_pament_dt { get; set; }
        public string eft_acc_no { get; set; }
        public string doc_path { get; set; }
        public string remarks { get; set; }
        public int status { get; set; }
        public string entry_by { get; set; }
        public Nullable<System.DateTime> entry_date { get; set; }
        public string update_by { get; set; }
        public Nullable<System.DateTime> update_date { get; set; }
    }
}
