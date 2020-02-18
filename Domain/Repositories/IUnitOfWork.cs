using System.Threading.Tasks;

namespace supermarket.sharp.api.Domain.Repositories
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}