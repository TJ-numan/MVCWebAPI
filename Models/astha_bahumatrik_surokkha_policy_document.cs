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
    
    public partial class astha_bahumatrik_surokkha_policy_document
    {
        public int id { get; set; }
        public string policy_no { get; set; }
        public string nominee_name { get; set; }
        public string reltion_client { get; set; }
        public string guardian_name { get; set; }
        public string reltion_nominee { get; set; }
        public Nullable<int> share_pct { get; set; }
        public string nominee_type { get; set; }
        public string nominee_photo_path { get; set; }
        public string nominee_nid_path { get; set; }
        public Nullable<System.DateTime> dob { get; set; }
    }
}
