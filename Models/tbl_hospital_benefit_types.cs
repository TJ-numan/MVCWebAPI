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
    
    public partial class tbl_hospital_benefit_types
    {
        public int id { get; set; }
        public string hospital_benefit_type_id { get; set; }
        public string charge_code { get; set; }
        public string hospital_benefit_name { get; set; }
        public string remarks { get; set; }
        public Nullable<System.DateTime> entry_date { get; set; }
        public string entry_by { get; set; }
        public Nullable<System.DateTime> updated_date { get; set; }
        public string updated_by { get; set; }
    }
}
