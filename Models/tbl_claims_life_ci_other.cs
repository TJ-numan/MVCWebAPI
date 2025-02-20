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
    
    public partial class tbl_claims_life_ci_other
    {
        public int id { get; set; }
        public string claim_no { get; set; }
        public string project_code { get; set; }
        public string claim_type_code { get; set; }
        public Nullable<System.DateTime> claim_date { get; set; }
        public string dispatch_no { get; set; }
        public Nullable<System.DateTime> dispatch_date { get; set; }
        public string document_want_reason { get; set; }
        public Nullable<System.DateTime> document_want_date { get; set; }
        public Nullable<System.DateTime> document_received_date { get; set; }
        public string org_code { get; set; }
        public string member_id { get; set; }
        public string employee_id { get; set; }
        public string plan_code { get; set; }
        public Nullable<System.DateTime> date_of_occurrence { get; set; }
        public string cause_of_death { get; set; }
        public string nature_of_death { get; set; }
        public string last_att_phy_reg_no { get; set; }
        public string hospital_name { get; set; }
        public Nullable<decimal> sum_assured { get; set; }
        public Nullable<decimal> claimed_amount { get; set; }
        public Nullable<decimal> settled_amount { get; set; }
        public Nullable<decimal> payable_amount { get; set; }
        public string payable_to { get; set; }
        public string nominee_name { get; set; }
        public string nom_bank_name { get; set; }
        public string nom_branch_name { get; set; }
        public string nom_ac_no { get; set; }
        public string nom_routing_no { get; set; }
        public string claim_status { get; set; }
        public Nullable<System.DateTime> claim_processing_date { get; set; }
        public string reject_reason { get; set; }
        public string special_note { get; set; }
        public Nullable<System.DateTime> payment_date { get; set; }
        public string payment_mode { get; set; }
        public string payment_detail { get; set; }
        public string entry_by { get; set; }
        public Nullable<System.DateTime> entry_date { get; set; }
        public string updated_by { get; set; }
        public Nullable<System.DateTime> updated_date { get; set; }
        public Nullable<int> idra_flag { get; set; }
    }
}
