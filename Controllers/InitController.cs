using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace supourlmarket_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InitController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] {"It", "Works !"};
        }
    }
}