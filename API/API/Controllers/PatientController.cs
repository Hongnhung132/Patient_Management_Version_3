using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    [RoutePrefix("api/patient")]
    public class PatientController : ApiController
    {
        DBContext DB = new DBContext();
        [Route("Studentdetails")]
        [HttpGet]
        public object Studentdetails()
        {

            var a = DB.Patients.ToList();
            return a;
        }

    }
}
