using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myWebAPI.Models
{
    public class LimitedClaimData
    {
        public int id { get; set; }
        public string claim_no { get; set; }
        public string project_code { get; set; }
        public string claim_category_code { get; set; }
        public string claim_type_code { get; set; }
    }
}