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
    
    public partial class tbl_hospitals
    {
        public int id { get; set; }
        public string hospital_code { get; set; }
        public string hospital_name { get; set; }
        public string contract_no { get; set; }
        public string contract_date { get; set; }
        public string hospital_address { get; set; }
        public string hospital_email { get; set; }
        public string hospital_phone { get; set; }
        public string hospital_area { get; set; }
        public string signatory_name { get; set; }
        public string signatory_designation { get; set; }
        public string signatory_mobile { get; set; }
        public string signatory_email { get; set; }
        public string payment_method { get; set; }
        public string contract_term { get; set; }
        public string cashless_status { get; set; }
        public string active_status { get; set; }
        public Nullable<System.DateTime> entry_date { get; set; }
        public string entry_by { get; set; }
        public Nullable<System.DateTime> updated_date { get; set; }
        public string updated_by { get; set; }
    }
}
