using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using supermarket.sharp.api.Domain.Models;

namespace supermarket.sharp.api.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}