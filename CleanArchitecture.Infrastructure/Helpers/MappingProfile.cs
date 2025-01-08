using AutoMapper;
using CleanArchitecture.Application.DTOs;
using CleanArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Map from Product entity to ProductDto
            CreateMap<Product, ProductDto>()
                .ForMember(dest => dest.TypeName, opt => opt.MapFrom(src => src.ProductType.Name)) // Example of mapping related properties
                .ForMember(dest => dest.BrandName, opt => opt.MapFrom(src => src.Brand.Name));

            // Map from ProductDto to Product entity
            CreateMap<ProductDto, Product>()
                .ForMember(dest => dest.ProductType, opt => opt.Ignore()) // Ignore complex properties
                .ForMember(dest => dest.Brand, opt => opt.Ignore());
        }
    }
}
