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
    
    public partial class tbl_ilb_desig_wise_targeted_prem
    {
        public int id { get; set; }
        public string desig_code { get; set; }
        public string prem_type { get; set; }
        public string target_type { get; set; }
        public Nullable<decimal> premium_amount { get; set; }
        public string target_year { get; set; }
        public string entry_by { get; set; }
        public string updated_by { get; set; }
        public Nullable<System.DateTime> entry_date { get; set; }
        public Nullable<System.DateTime> updated_date { get; set; }
    }
}
