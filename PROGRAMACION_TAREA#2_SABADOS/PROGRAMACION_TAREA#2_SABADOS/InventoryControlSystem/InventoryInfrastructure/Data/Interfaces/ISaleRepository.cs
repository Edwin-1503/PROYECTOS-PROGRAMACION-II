using InventoryDomain.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InventoryInfrastructure.Data.Interfaces
{
    public interface ISaleRepository
    {
        Task<IEnumerable<Sale>> GetAllAsync();
        Task<Sale> GetByIdAsync(int id);
        Task AddAsync(Sale sale);
        Task DeleteAsync(int id);
    }
}
