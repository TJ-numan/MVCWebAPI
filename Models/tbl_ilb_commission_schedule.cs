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
    
    public partial class tbl_ilb_commission_schedule
    {
        public int id { get; set; }
        public Nullable<double> term { get; set; }
        public Nullable<double> first_year { get; set; }
        public Nullable<double> second_year { get; set; }
        public Nullable<double> third_year { get; set; }
        public Nullable<double> business_type { get; set; }
        public string user_id { get; set; }
        public Nullable<System.DateTime> entry_date { get; set; }
        public Nullable<double> single_premium { get; set; }
    }
}
