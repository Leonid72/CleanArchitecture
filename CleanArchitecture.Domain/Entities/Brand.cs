﻿
namespace CleanArchitecture.Domain.Entities
{
    public class Brand: BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string LogoUrl { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
