using InventoryDomain.Core.Base;
using System;

namespace InventoryDomain.Core.Entities
{
    public class Sale : BaseEntity
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int QuantitySold { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalAmount => QuantitySold * Product.SalePrice;
    }
}
