using System.Collections.Generic;
using System.Threading.Tasks;
using supermarket.sharp.api.Domain.Models;
using supermarket.sharp.api.Domain.Repositories;
using supermarket.sharp.api.Domain.Services;

namespace supermarket.sharp.api.Services
{
    public class ProductService : IProductService
    {

        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        
        public async Task<IEnumerable<Product>> ListAsync()
        {
            return await _productRepository.ListAsync();
        }
    }
}