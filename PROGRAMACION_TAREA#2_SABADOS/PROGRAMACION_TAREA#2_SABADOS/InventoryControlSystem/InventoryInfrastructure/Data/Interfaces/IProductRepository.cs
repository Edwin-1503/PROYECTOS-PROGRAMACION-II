using InventoryDomain.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InventoryInfrastructure.Data.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int id);
        Task AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(int id);
    }
}
