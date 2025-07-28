using InventoryDomain.Core.Base;
using System;

namespace InventoryDomain.Core.Entities
{
    public class Purchase : BaseEntity
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int QuantityPurchased { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalCost => QuantityPurchased * Product.CostPrice;
    }
}
