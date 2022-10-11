using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arquetipo.Domain.IRepository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<int> Add(T entity);
        Task<int> AddRange(List<T> entity);
        Task<T> Get(int id);
        Task<List<T>> GetAll();
        Task<int> Update(T entity);
        Task<int> Delete(int id);
    }
}
