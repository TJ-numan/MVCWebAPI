using myWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace myWebAPI.Controllers
{
    public class PolicyDefaultController : ApiController
    {
        IMS_ASTHAEntities db = new IMS_ASTHAEntities();
        
        // method for getting all data
        [HttpGet]
        public IHttpActionResult GetData()
        {
            List<tbl_claims> list = db.tbl_claims.ToList();
            return Ok(list);
        }


        // method for limited data
        [HttpGet]
        public IHttpActionResult GetData(int id)
        {
            List<tbl_claims> list = db.tbl_claims.Take(id).ToList();
            return Ok(list);
        }





        //  method for limited data with limited columns
        [HttpGet]
        [Route("api/PolicyDefault/Limited/{limit:int}")]
        public IHttpActionResult GetLimitedData(int limit)
        {
            
            string query = "SELECT TOP(@limit) id, claim_no, project_code, claim_category_code, claim_type_code FROM tbl_claims";

         
            var result = db.Database.SqlQuery<LimitedClaimData>(query, new SqlParameter("@limit", limit)).ToList();

      
            if (result == null || !result.Any())
            {
                return NotFound();
            }

            return Ok(result); 
        }













        // GetLimitedData mathod with LinQ
        //[HttpGet]
        //[Route("api/PolicyDefault/Limited/{limit:int}")]
        //public IHttpActionResult GetLimitedData(int limit)
        //{
        //    var list = db.tbl_claims
        //                 .Take(limit)
        //                 .Select(c => new
        //                 {
        //                     c.id,
        //                     c.claim_no,
        //                     c.project_code,
        //                     c.claim_category_code,
        //                     c.claim_date
        //                 })
        //                 .ToList();

        //    return Ok(list);
        //}



    }
}
