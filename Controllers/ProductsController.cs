using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using supermarket.sharp.api.Domain.Models;
using supermarket.sharp.api.Domain.Services;
using supermarket.sharp.api.Resources;

namespace supermarket.sharp.api.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductsController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }
        
        /// <summary>
        /// Lists all products.
        /// </summary>
        /// <returns>List of products.</returns>
        [HttpGet]
        public async Task<IEnumerable<ProductResource>> ListAsync()
        {
            IEnumerable<Product> products = await _productService.ListAsync();
            var ressources = _mapper.Map<IEnumerable<Product>, IEnumerable<ProductResource>>(products);
            return ressources;
        }
    }
}