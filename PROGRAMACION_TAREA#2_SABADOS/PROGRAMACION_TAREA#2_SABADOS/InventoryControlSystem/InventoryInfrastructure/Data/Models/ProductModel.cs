namespace InventoryInfrastructure.Data.Models
{
    public class ProductModel
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SalePrice { get; set; }
        public int CategoryId { get; set; }
    }
}


