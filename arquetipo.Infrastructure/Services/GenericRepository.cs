using arquetipo.Domain.IRepository;
using arquetipo.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace arquetipo.Infrastructure.Services
{
    public class GenericRepository<T>:IGenericRepository<T> where T:class
    {
        private readonly db_creditoautoContext _context;
        public GenericRepository(db_creditoautoContext context)
        {
            _context = context;
        }
        public async Task<int> Add(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> AddRange(List<T> entity)
        {
            await _context.Set<T>().AddRangeAsync(entity);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int id)
        {
            T element = await _context.Set<T>().FindAsync(id);
            _context.Set<T>().Remove(element);
            return await _context.SaveChangesAsync();
        }

        public async Task<T> Get(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<List<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<int> Update(T entity)
        {
            _context.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            return await _context.SaveChangesAsync();
        }
    }
}
