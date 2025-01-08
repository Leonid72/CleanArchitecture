
namespace CleanArchitecture.Application.DTOs
{
    public class BrandDto : BaseEntityDto
    {
        public string Name { get; set; }
        public string? Description { get; set; } = string.Empty;
        public string? LogoUrl{get; set;} = string.Empty;
    }
}
