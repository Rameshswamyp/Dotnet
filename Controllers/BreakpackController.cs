using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;


namespace Breakpack_Operations.Controllers
{
    [System.Web.Http.Route("api/[controller]")]
    [ApiController]
    public class BreakpackController : ApiController
    {

        IList<Breakpack> Breakpacklist = new List<Breakpack>()
        {
            new Breakpack()
            {
                Id = 1,
                Type = "Type1"

            },
            new Breakpack()
            {
                Id = 2,
                Type = "Type2"

            }


        };
        [System.Web.Http.HttpGet]
        public IList<Breakpack> GetallDetails()
        {

            return Breakpacklist;
        }
        [System.Web.Http.HttpGet]
        public Breakpack GetBreakpackDetails(int id)
        {

            var breaklist1 = Breakpacklist.FirstOrDefault(e => e.Id == id);
            if (breaklist1 == null)
            {
               // throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }
            return breaklist1;
        }
    }
}
