using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;


namespace CleanArchitecture.Infrastructure.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
            _context= context;
        }

        public async Task<List<Product>> GetProductsByBrandAsync(int brandId)
        {
            return await _context.Products
                         .Include(p => p.Brand)
                         .Where(p=>p.Id == brandId).ToListAsync();
        }

        public async Task<List<Product>> GetProductsByPriceRangeAsync(decimal minPrice, decimal maxPrice)
        {
            return await _context.Products.Where(p=>p.Price >= minPrice && p.Price <= maxPrice).ToListAsync();
        }

        public async Task<List<Product>> GetProductsByTypeAsync(int typeId)
        {
            return await _context.Products
                         .Include(p => p.ProductType)
                         .Where(p => p.Id == typeId).ToListAsync();
        }

        public async Task<List<Product>> GetProductsWithBrandAndTypeAsync()
        {
            return await _context.Products
                         .Include(p => p.Brand)
                         .Include(p => p.ProductType)
                         .ToListAsync();
        }
    }
}
