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
    
    public partial class tbl_short_premium_adjusted_bm
    {
        public int id { get; set; }
        public string proposal_no { get; set; }
        public Nullable<double> adjusted_premium { get; set; }
        public string bm_code_old { get; set; }
        public string bm_code { get; set; }
        public Nullable<int> flag { get; set; }
        public string entry_by { get; set; }
        public Nullable<System.DateTime> entry_date { get; set; }
    }
}
