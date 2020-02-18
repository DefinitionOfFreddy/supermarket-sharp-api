using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using supermarket.sharp.api.Domain.Models;
using supermarket.sharp.api.Domain.Services;

namespace supermarket.sharp.api.Controllers
{
    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {

        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        
        [HttpGet]
        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            IEnumerable<Category> categories = await _categoryService.ListAsync();
            return categories;
        }
    }
}