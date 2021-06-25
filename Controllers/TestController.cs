using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Breakpack_Operations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("get.{format}"), FormatFilter]
        public IEnumerable<Breakpack> Get()
        {
            List<Breakpack> listPack = new List<Breakpack>
            {
                new Breakpack { Id = 1, Type = "Type11", Name="Lift1" },
                new Breakpack { Id = 2, Type = "Type22", Name="Lift2"},
                new Breakpack { Id = 3, Type = "Type22", Name="Lift3"}
            };
            return listPack;
        }

        [HttpPost("post.{format}"), FormatFilter]
        public Breakpack Post([FromBody] Breakpack listpack)
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
