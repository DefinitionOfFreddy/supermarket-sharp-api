using Microsoft.AspNetCore.Mvc;

namespace supermarket.sharp.api.Controllers
{
    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        
        [HttpGet]
        public int GetAllAsync()
        {
            return 0;
        }
    }
}