
namespace CleanArchitecture.Domain.Entities
{
    public class Product: BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity
        {
            get; set;
        }
        public int ProuctTypeId { get; set; }
        public ProductType ProductType { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
    }
}
