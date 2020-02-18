using System.Collections.Generic;
using System.Threading.Tasks;
using supermarket.sharp.api.Domain.Models;
using supermarket.sharp.api.Domain.Repositories;
using supermarket.sharp.api.Domain.Services;

namespace supermarket.sharp.api.Services
{
    public class CategoryService : ICategoryService
    {

        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        
        public async Task<IEnumerable<Category>> ListAsync()
        {
            IEnumerable<Category> categories = await _categoryRepository.ListAsync();
            return categories;
        }
    }
}