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
    
    public partial class tbl_ilb_policy_lapse_revive_required_doc
    {
        public int id { get; set; }
        public string doc_type { get; set; }
        public string doc_path { get; set; }
        public string policy_no { get; set; }
        public string premium_collection_id { get; set; }
        public string col_ref_no { get; set; }
        public string entry_by { get; set; }
        public Nullable<System.DateTime> entry_date { get; set; }
    }
}
