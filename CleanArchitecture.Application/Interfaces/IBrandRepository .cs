using CleanArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Interfaces
{
    public interface IBrandRepository : IGenericRepository<Brand>
    {
        Task<List<Brand>> GetBrandWitProductshAsync();
    }
}
