using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet("get.{format}"), FormatFilter]
        public IEnumerable<TestClass> Get()
        {
            List<TestClass> listPack = new List<TestClass>
            {
                new TestClass {  Id = 1, Type = "Type11", Name="Lift1" },
                new TestClass { Id = 2, Type = "Type22", Name="Lift2"},
                new TestClass { Id = 3, Type = "Type22", Name="Lift3"}
            };
            return listPack;
        }

        [HttpPost("post.{format}"), FormatFilter]
        public Test Post([FromBody] Test listpack)
        {
            if (ModelState.IsValid)
            {
                return listpack;
            }
            else
            {
                return null;
            }
        }
    
}
}
