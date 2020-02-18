using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using supermarket.sharp.api.Domain.Models;
using supermarket.sharp.api.Domain.Repositories;
using supermarket.sharp.api.Persistence.Contexts;

namespace supermarket.sharp.api.Persistence.Repositories
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _context.Categories.ToListAsync();
        }
    }
}