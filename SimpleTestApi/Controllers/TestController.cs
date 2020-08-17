using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SimpleTestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        string testPost = "posted a value";
        string testPut = "put a value";
        string testDelete = "deleted a value";

        // GET: api/<TestController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TestController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "got a value " + id;
        }

        // POST api/<TestController>
        [HttpPost]
        public string Post([FromBody] string value)
        {
            return testPost;
        }

        // PUT api/<TestController>/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] string value)
        {
            return testPut;
        }

        // DELETE api/<TestController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return testDelete;
        }
    }
}
