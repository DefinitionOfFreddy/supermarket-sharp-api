using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using supermarket.sharp.api.Domain.Models;
using supermarket.sharp.api.Domain.Services;
using supermarket.sharp.api.Resources;

namespace supermarket.sharp.api.Controllers
{
    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {

        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoriesController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }
        
        [HttpGet]
        public async Task<IEnumerable<CategoryRessource>> GetAllAsync()
        {
            IEnumerable<Category> categories = await _categoryService.ListAsync();
            IEnumerable<CategoryRessource> ressources =
                _mapper.Map<IEnumerable<Category>, IEnumerable<CategoryRessource>>(categories); 
            return ressources;
        }
    }
}