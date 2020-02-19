using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using supermarket.sharp.api.Domain.Models;
using supermarket.sharp.api.Domain.Services.Communication;

namespace supermarket.sharp.api.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
        Task<CategoryResponse> SaveAsync(Category category);
        Task<CategoryResponse> UpdateAsync(int id, Category category);
        Task<CategoryResponse> DeleteAsync(int id);
    }
}