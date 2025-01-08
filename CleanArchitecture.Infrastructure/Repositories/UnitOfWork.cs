using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            Product = new ProductRepository(_dbContext);
            Brand = new BrandRepository(_dbContext);
            ProductType = new ProductTypeRepository(_dbContext);
        }

        public IProductRepository Product { get; private set; }
        public IBrandRepository Brand { get; private set; }
        public IProductTypeRepository ProductType { get; private set; }


        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }
    }
}
