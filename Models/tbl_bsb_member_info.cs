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
    
    public partial class tbl_bsb_member_info
    {
        public int id { get; set; }
        public string school_or_clg_name { get; set; }
        public string eiin { get; set; }
        public Nullable<System.DateTime> comm_date { get; set; }
        public string student_id { get; set; }
        public string student_name { get; set; }
        public Nullable<System.DateTime> student_dob { get; set; }
        public string student_birth_reg_no { get; set; }
        public string student_class { get; set; }
        public string guardian_name { get; set; }
        public Nullable<System.DateTime> guardian_dob { get; set; }
        public string relation_with_student { get; set; }
        public string guardian_nid { get; set; }
        public string mobile { get; set; }
        public string guardian_gender { get; set; }
        public string guardian_occupation { get; set; }
        public string present_address { get; set; }
        public string permanent_address { get; set; }
        public Nullable<System.DateTime> effective_date { get; set; }
        public string number_of_unit { get; set; }
        public Nullable<decimal> premium { get; set; }
        public string remarks { get; set; }
        public string claim_status { get; set; }
        public string entry_by { get; set; }
        public Nullable<System.DateTime> entry_date { get; set; }
        public string updated_by { get; set; }
        public Nullable<System.DateTime> updated_date { get; set; }
    }
}
