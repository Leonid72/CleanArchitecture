using CleanArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Interfaces
{
    public interface IProductTypeRepository : IGenericRepository<ProductType>
    {
        Task<List<ProductType>> GetTypesWithProductsAsync();
    }
}
