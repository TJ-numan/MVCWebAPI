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
    
    public partial class tbl_ilb_hi_due_update
    {
        public int id { get; set; }
        public int policy_no { get; set; }
        public System.DateTime policy_date { get; set; }
        public double prev_hi_prem_net { get; set; }
        public double prev_hi_prem_discount { get; set; }
        public double prev_hi_prem_total { get; set; }
        public double current_hi_prem_net { get; set; }
        public double current_hi_prem_discount { get; set; }
        public double current_hi_prem_total { get; set; }
        public System.DateTime updated_on { get; set; }
    }
}
