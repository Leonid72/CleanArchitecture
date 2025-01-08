
namespace CleanArchitecture.Domain.Entities
{
    public class ProductType: BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        // Navigation property
        public ICollection<Product> Products { get; set; }
    }
}
