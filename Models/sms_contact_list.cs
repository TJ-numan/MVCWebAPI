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
    
    public partial class sms_contact_list
    {
        public int id { get; set; }
        public string contact_no { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public string user_id { get; set; }
        public Nullable<System.DateTime> updated_date { get; set; }
        public string unique_key { get; set; }
        public Nullable<int> flag { get; set; }
    }
}
