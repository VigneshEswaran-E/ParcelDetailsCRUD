using BusinessLayer;
using BusinessLayer.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ParcelDetailsCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        ILocationRepository rep = null;
        public LocationController(ILocationRepository reppp)
        {
            rep = reppp;
        }


        // GET: api/<LocationController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(rep.GetAllLocation());
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // GET api/<LocationController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LocationController>
        [HttpPost]
        public IActionResult Post([FromBody] Location value)
        {
            try
            {
                rep.InsertLocation(value);
                return Ok();
            }catch(Exception ex)
            {
                throw;
            }
        }

        // PUT api/<LocationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LocationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
