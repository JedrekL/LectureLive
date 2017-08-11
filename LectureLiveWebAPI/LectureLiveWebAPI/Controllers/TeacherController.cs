using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LectureLiveWebAPI.Controllers
{
    public class TeacherController : ApiController
    {
        private string databaseFile = @"C:\Users\leons\Documents\database.txt";

        // GET api/values
        public IEnumerable<string> Get()
        {
            return File.ReadAllLines(databaseFile);
        }
    }
}
