using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SelfHostApi.Helper;

namespace SelfHostApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            FileWriter.WriteToFile($"{DateTime.UtcNow.ToString("O")}: Received GET");
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            FileWriter.WriteToFile($"{DateTime.UtcNow.ToString("O")}: Received GET {id}");
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
            FileWriter.WriteToFile($"{DateTime.UtcNow.ToString("O")}: Received by POST: {value}");
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            FileWriter.WriteToFile($"{DateTime.UtcNow.ToString("O")}: Received by PUT: {id} | {value}");
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            FileWriter.WriteToFile($"{DateTime.UtcNow.ToString("O")}: Received by DELETE: {id}");
        }
    }
}
