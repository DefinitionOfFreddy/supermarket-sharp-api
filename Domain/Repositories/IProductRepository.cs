using System.Collections.Generic;
using System.Threading.Tasks;
using supermarket.sharp.api.Domain.Models;

namespace supermarket.sharp.api.Domain.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> ListAsync();
    }
}