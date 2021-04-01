using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EPCShop.Data.Models;
using EPCShop.Data;
using System.Data.Entity;
using EPCShop.Data.Interfaces;
using EPCShop.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EPCShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        IAllPcs AllPcs;
        public HomeController (IAllPcs allPcs)
        {
            AllPcs = allPcs;
        }

        // GET: api/<HomeController>
        [HttpGet(Name = "GetAllPcs")]
        public IEnumerable<Pc> Get()
        {
            return AllPcs.GetPcs();
        }

        // GET api/<HomeController>/1
        [HttpGet("{id}")]
        public ActionResult<Pc> Get(int id)
        {
            return AllPcs.getObjectPc(id);
        }
    }
}
