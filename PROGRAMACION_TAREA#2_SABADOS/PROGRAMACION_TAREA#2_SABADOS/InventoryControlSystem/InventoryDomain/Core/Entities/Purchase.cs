using InventoryDomain.Core.Base;

namespace InventoryDomain.Core.Entities
{
    public class Supplier : BaseEntity
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
