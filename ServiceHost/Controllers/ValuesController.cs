using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DomainObjects;
using HospitalCore;
using Microsoft.AspNetCore.Mvc;
using PrimaryPort;

namespace ServiceHost.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        ITestCoreClass TestCoreClass = null;
        IPatientCore _patientCore = null;
        public ValuesController(ITestCoreClass testCoreClass, IPatientCore patientCore)
        {
            TestCoreClass = testCoreClass;
            _patientCore = patientCore;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<TestModel>> Get()
        {
           return TestCoreClass.GetFootBallPoints();
            //return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<PatientObject> Get(string id)
        {
            return _patientCore.GetPatient(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
