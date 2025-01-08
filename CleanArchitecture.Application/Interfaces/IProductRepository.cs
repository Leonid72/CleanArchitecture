using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Domain.Entities;


namespace CleanArchitecture.Application.Interfaces
{
    public interface IProductRepository: IGenericRepository<Product>
    {
        Task<List<Product>> GetProductsByPriceRangeAsync(decimal minPrice, decimal maxPrice);
        Task<List<Product>> GetProductsByBrandAsync(int brandId);
        Task<List<Product>> GetProductsByTypeAsync(int typeId);
        Task<List<Product>> GetProductsWithBrandAndTypeAsync();
    }
}
