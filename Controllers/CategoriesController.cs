using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using supermarket.sharp.api.Domain.Models;
using supermarket.sharp.api.Domain.Services;
using supermarket.sharp.api.Domain.Services.Communication;
using supermarket.sharp.api.Extensions;
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

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SaveCategoryResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessage());
            
            Category category = _mapper.Map<SaveCategoryResource, Category>(resource);
            CategoryResponse result = await _categoryService.SaveAsync(category);

            if (!result.Success)
                return BadRequest(result.Message);

            var categoryRessource = _mapper.Map<Category, CategoryRessource>(category);
            return Ok(categoryRessource);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(int id, [FromBody] SaveCategoryResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessage());

            Category category = _mapper.Map<SaveCategoryResource, Category>(resource);

            CategoryResponse result = await _categoryService.UpdateAsync(id, category);

            if (!result.Success)
                return BadRequest(result.Message);

            CategoryRessource categoryRessource = _mapper.Map<Category, CategoryRessource>(result.Category);

            return Ok(categoryRessource);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessage());

            CategoryResponse result = await _categoryService.DeleteAsync(id);

            if (!result.Success)
                return BadRequest(result.Message);

            CategoryRessource categoryRessource = _mapper.Map<Category, CategoryRessource>(result.Category);

            return Ok(categoryRessource);
        }
        
    }
}