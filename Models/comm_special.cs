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
    
    public partial class comm_special
    {
        public int id { get; set; }
        public string empid { get; set; }
        public Nullable<decimal> amount { get; set; }
        public Nullable<System.DateTime> effective_date { get; set; }
        public Nullable<int> status { get; set; }
        public string doc_path { get; set; }
        public Nullable<System.DateTime> entry_date { get; set; }
    }
}
