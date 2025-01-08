
namespace CleanArchitecture.Application.DTOs
{
    public class ProductTypeDto: BaseEntityDto
    {
        public string Name { get; set; }
        public string? Description { get; set; } = string.Empty;
    }
}
