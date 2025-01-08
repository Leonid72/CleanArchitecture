
using AutoMapper;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(T entity) => await _context.Set<T>().AddAsync(entity);


        public async Task DeleteAsync(T entity) =>  _context.Set<T>().Remove(entity);


        public async Task<List<T>> Find(System.Linq.Expressions.Expression<Func<T, bool>> predicate) 
            => await _context.Set<T>().Where(predicate).ToListAsync();


        public async Task<IEnumerable<T>> GetAllAsync() => await _context.Set<T>().ToListAsync();


        public async Task<T> GetByIdAsync(int id) => _context.Set<T>().Find(id);


        public async Task UpdateAsync(T entity) => _context.Set<T>().Update(entity);
    }
}
