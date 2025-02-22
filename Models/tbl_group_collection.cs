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
    
    public partial class tbl_group_collection
    {
        public int collection_Id { get; set; }
        public string bill_no { get; set; }
        public string bill_type { get; set; }
        public string org_code { get; set; }
        public string business_month { get; set; }
        public string collection_type { get; set; }
        public string cheque_number { get; set; }
        public string cheque_date { get; set; }
        public string eft_number { get; set; }
        public string eft_date { get; set; }
        public string bank_name { get; set; }
        public string branch { get; set; }
        public string pr_no { get; set; }
        public Nullable<decimal> total_collection { get; set; }
        public Nullable<decimal> life_premium { get; set; }
        public Nullable<decimal> health_premium { get; set; }
        public Nullable<decimal> balance { get; set; }
        public Nullable<decimal> lives { get; set; }
        public Nullable<decimal> employees { get; set; }
        public Nullable<decimal> spouse { get; set; }
        public Nullable<decimal> child { get; set; }
        public Nullable<decimal> adb_prem { get; set; }
        public Nullable<decimal> ptd_prem { get; set; }
        public Nullable<decimal> ppr_prem { get; set; }
        public Nullable<decimal> ci_prem { get; set; }
        public Nullable<decimal> optical_prem { get; set; }
        public Nullable<decimal> dental_prem { get; set; }
        public Nullable<decimal> ppd_prem { get; set; }
        public Nullable<decimal> mat_prem { get; set; }
        public Nullable<decimal> other_prem { get; set; }
        public Nullable<decimal> opd_prem { get; set; }
        public Nullable<decimal> covid19_positive_prem { get; set; }
        public string billing_cycle { get; set; }
        public string cycle_start_date { get; set; }
        public string cycle_end_date { get; set; }
        public string entry_by { get; set; }
        public Nullable<System.DateTime> entry_date { get; set; }
        public string updated_by { get; set; }
        public Nullable<System.DateTime> updated_date { get; set; }
    }
}
