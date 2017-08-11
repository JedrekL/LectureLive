using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LectureLiveWebAPI.Controllers
{
    public class StudentController : ApiController
    {
        private string databaseFile = @"C:\Users\leons\Documents\database.txt";

        // GET api/student
        public IEnumerable<string> Get()
        {
            return null;
        }

        // GET api/student/5
        public string Get(int id)
        {

            return null;
            
        }

        // POST api/student
        public void Post([FromBody]string value)
        {
        }

        // PUT api/student/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/student/5
        public void Delete(int id)
        {
        }
    }
}
