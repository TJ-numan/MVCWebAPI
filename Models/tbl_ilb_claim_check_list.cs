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
    
    public partial class tbl_ilb_claim_check_list
    {
        public int id { get; set; }
        public string claim_no { get; set; }
        public string ques_id { get; set; }
        public string ques_name { get; set; }
        public Nullable<bool> status { get; set; }
        public string page_number { get; set; }
        public string entry_by { get; set; }
        public Nullable<System.DateTime> entry_date { get; set; }
    }
}
