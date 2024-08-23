using DataAccessLayer.entity;
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
    public class ParcelController : ControllerBase
    {
        ParceldetailsRepository reg = null;
        public ParcelController()
        {
            reg = new ParceldetailsRepository();
        }
        // GET: api/<ParcelController>
        [HttpGet]
        public IEnumerable<Parceldetails> Get()
        {
            return reg.ShowAllParcel();
        }

        // GET api/<ParcelController>/5
        [HttpGet("{ParcelId}")]
        public Parceldetails Get(long ParcelID)
        {
            return reg.ShowParcelbyName(ParcelID);
        }

        // POST api/<ParcelController>
        [HttpPost]
        public void Post([FromBody] Parceldetails value )
        {
            reg.Details(value);
        }

        // PUT api/<ParcelController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Parceldetails value)
        {
            reg.UpdateDetails(value);
        }

        // DELETE api/<ParcelController>/5
        [HttpDelete("{ParcelID}")]
        public void Delete(long ParcelID)
        {
           reg.DeleteDetails(ParcelID);
        }
    }
}
