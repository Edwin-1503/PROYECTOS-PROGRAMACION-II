using InventoryDomain.Core.Base;

namespace InventoryDomain.Core.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SalePrice { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
