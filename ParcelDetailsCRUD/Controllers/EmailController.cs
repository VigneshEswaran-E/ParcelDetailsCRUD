using BusinessLayer;
using BusinessLayer.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ParcelDetailsCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IEmailController : ControllerBase
    {
        private readonly IEmailRepository _mailsending;
        private readonly IConfiguration _configuration;

            public IEmailController(IEmailRepository mailsending, IConfiguration configuration)
        {
            _configuration = configuration;
            _mailsending = mailsending;
        }


        // GET: api/<EmailController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<EmailController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EmailController>
        [HttpPost]
        public ActionResult<Email> Post([FromBody] Email value)
        {
            var FromAddress = _configuration.GetSection("FromAddress").Value;
            var Password = _configuration.GetSection("password").Value;
            _mailsending.SendEmail(FromAddress,  value.ToAddress, Password,  value.Body,value.Subject);
            return Ok();
        }

        // PUT api/<EmailController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmailController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
