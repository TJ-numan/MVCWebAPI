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
    
    public partial class tbl_ilb_proposal_formno_info
    {
        public int id { get; set; }
        public string form_no { get; set; }
        public Nullable<System.DateTime> purchase_date { get; set; }
        public Nullable<System.DateTime> issue_date { get; set; }
        public string issue_officecode { get; set; }
        public string status { get; set; }
        public string reason { get; set; }
        public string user_id { get; set; }
        public Nullable<System.DateTime> entry_date { get; set; }
        public string bm_code { get; set; }
        public Nullable<System.DateTime> expire_date { get; set; }
        public string bm_code_old { get; set; }
        public string remarks { get; set; }
        public Nullable<System.DateTime> update_date { get; set; }
    }
}
