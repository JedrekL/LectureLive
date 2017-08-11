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
        Dictionary<string, List<studentResponse>> globalDictionary = null;
        

        // GET: api/Class
        public IEnumerable<string> Get()
        {

            //Create a classroom
            Random rng = new Random();
            string classId = rng.Next(111, 999).ToString();
            Responses sR = new Responses();
            DateTime time = new DateTime();
            sR.classStarted = time.Ticks;
            sR.resp = new List<studentResponse>();
            sR.className = classId;

            List<studentResponse> list;
            Dictionary<string, List<studentResponse>> classResponses = globalDictionary;
            if (classResponses != null)
            {
                classResponses.TryGetValue(classId, out list);
                if(list != null)
                {
                    
                } else
                {
                    globalDictionary.Add(sR.className, sR.resp);
                }
            }
            else
            {
                new Dictionary<string, List<studentResponse>>();
            }
            return new string[] { classId };
           
        }

        // GET: api/Class/5
        public string Get(int id)
        {
            studentResponse newResponse = new studentResponse();
            newResponse.response = id;
            

            return null;
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
