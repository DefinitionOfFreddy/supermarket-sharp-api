using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace supermarket.sharp.api.Controllers
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