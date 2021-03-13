using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EPCShop.Data.Models;
using EPCShop.Data;
using System.Data.Entity;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EPCShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        // GET: api/<HomeController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pc>>> Get(AppDBContent db)
        {
            return await db.Pc.ToListAsync();
        }

        // GET api/<HomeController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pc>> Get(int id, AppDBContent db)
        {
            Pc pc = await db.Pc.FirstOrDefaultAsync(x => x.id == id);
            if (pc == null)
                return NotFound();
            return new ObjectResult(pc);
        }

        // POST api/<HomeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<HomeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<HomeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
