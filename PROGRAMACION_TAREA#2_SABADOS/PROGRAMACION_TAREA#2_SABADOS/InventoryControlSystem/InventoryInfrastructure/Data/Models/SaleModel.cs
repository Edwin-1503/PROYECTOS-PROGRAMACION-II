using System;

namespace InventoryInfrastructure.Data.Models
{
    public class SaleModel
    {
        public int ProductId { get; set; }
        public int QuantitySold { get; set; }
        public DateTime Date { get; set; }
    }
}
