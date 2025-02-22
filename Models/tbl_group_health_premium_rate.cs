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
    
    public partial class tbl_group_health_premium_rate
    {
        public int id { get; set; }
        public string org_code { get; set; }
        public string plan_code { get; set; }
        public Nullable<decimal> ci_premium { get; set; }
        public Nullable<decimal> hospitalization_self { get; set; }
        public Nullable<decimal> hospitalization_spouse { get; set; }
        public Nullable<decimal> hospitalization_dependent { get; set; }
        public Nullable<decimal> hospitalization_parent { get; set; }
        public Nullable<decimal> opd_self { get; set; }
        public Nullable<decimal> opd_spouse { get; set; }
        public Nullable<decimal> opd_dependent { get; set; }
        public Nullable<decimal> opd_parent { get; set; }
        public Nullable<decimal> dental_self { get; set; }
        public Nullable<decimal> dental_spouse { get; set; }
        public Nullable<decimal> dental_dependent { get; set; }
        public Nullable<decimal> dental_parent { get; set; }
        public Nullable<decimal> optical_self { get; set; }
        public Nullable<decimal> optical_spouse { get; set; }
        public Nullable<decimal> optical_dependent { get; set; }
        public Nullable<decimal> optical_parent { get; set; }
        public Nullable<decimal> maternity_self { get; set; }
        public Nullable<decimal> maternity_spouse { get; set; }
        public Nullable<decimal> maternity_dependent { get; set; }
        public Nullable<decimal> maternity_parent { get; set; }
        public Nullable<decimal> others_self { get; set; }
        public Nullable<decimal> others_spouse { get; set; }
        public Nullable<decimal> others_dependent { get; set; }
        public Nullable<decimal> others_parent { get; set; }
        public Nullable<decimal> covid19_positive_premium { get; set; }
        public Nullable<decimal> covid19_death_premium { get; set; }
        public Nullable<decimal> covid19_life_premium { get; set; }
        public string entry_by { get; set; }
        public Nullable<System.DateTime> entry_date { get; set; }
        public string updated_by { get; set; }
        public Nullable<System.DateTime> updated_date { get; set; }
    }
}
