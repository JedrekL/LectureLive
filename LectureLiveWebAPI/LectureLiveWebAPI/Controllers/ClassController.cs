using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LectureLiveWebAPI.Controllers
{
    public class ClassController : ApiController
    {
        // GET: api/Class
        public IEnumerable<string> Get()
        {
            //string classid = Random.Next(111,999).ToString();
            //Responses sR = new Responses();
            //sR.classStarted = DateTime.Now();
            //sR.resp = new List<studentResponse>();
            //Dictionary<string, studentResponse> classResponses;
            


            return new string[] { "value1", "value2" };

            
        }

        // GET: api/Class/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Class
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Class/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Class/5
        public void Delete(int id)
        {
        }
    }
}
