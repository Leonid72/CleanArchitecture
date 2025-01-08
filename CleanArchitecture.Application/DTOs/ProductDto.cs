
namespace CleanArchitecture.Application.DTOs
{
    public class ProductDto: BaseEntityDto
    {
        public string Name { get; set; }
        public string? Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public string BrandName { get; set; }
        public string TypeName { get; set; }
    }
}
