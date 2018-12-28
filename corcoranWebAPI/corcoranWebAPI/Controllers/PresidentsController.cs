using System.Collections.Generic;
using corcoranWebAPI.MockData;
using corcoranWebAPI.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace corcoranWebAPI.Controllers
{
    [Route("api/[controller]")]

    public class PresidentsController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<President> Get()
        {
            return new Presidents().presidents();

        }
        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
