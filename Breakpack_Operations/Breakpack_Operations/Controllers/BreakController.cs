using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Breakpack_Operations.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BreakpackController : ControllerBase
    {
       
        IList<Breakpack> Breakpacklist = new List<Breakpack>()
        {
            new Breakpack()
            {
                Id = 1,
                Type = "Type1",
                Name="Lift1"

            },
            new Breakpack()
            {
                Id = 2,
                Type = "Type2",
                Name="Lift2"
            }


        };
        [HttpGet]
        public IList<Breakpack> GetallDetails()
        {
            return Breakpacklist;
        }


        [HttpGet("get.{format}"), FormatFilter]
        public IEnumerable<Breakpack> Get()
        {
            List<Breakpack> listPack = new List<Breakpack>
            {
                new Breakpack { Id = 1, Type = "Type1", Name="Operation" },
                new Breakpack { Id = 2, Type = "Type2", Name="Operation"},
                new Breakpack { Id = 3, Type = "Type3", Name="Operation"}
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
