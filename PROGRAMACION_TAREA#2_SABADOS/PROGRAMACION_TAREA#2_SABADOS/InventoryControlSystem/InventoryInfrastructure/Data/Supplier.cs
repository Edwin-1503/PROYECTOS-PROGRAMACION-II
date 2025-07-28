using InventoryDomain.Core.Base;

namespace InventoryDomain.Core.Entities
{
    public class Supplier : BaseEntity
    {
        public string Name { get; set; }
        public string ContactInfo { get; set; }
    }
}
