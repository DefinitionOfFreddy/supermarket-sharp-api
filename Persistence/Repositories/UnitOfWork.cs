using System.Threading.Tasks;
using supermarket.sharp.api.Domain.Repositories;
using supermarket.sharp.api.Persistence.Contexts;

namespace supermarket.sharp.api.Persistence.Repositories
{
       
    public class UnitOfWork : IUnitOfWork
    {
        
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }
        
        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}