using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ReporsitoryInterfaces
{
    public interface IAsyncRepository<T> where T : class
    {
        // common CRUD operations that will be used by all other repositories

        // async/await

        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> ListAllAsync();
        Task<IEnumerable<T>> ListAsync(Expression<Func<T, bool>> filter);
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(T entity);
        Task<int> GetCountAsync(Expression<Func<T, bool>> filter = null);
    }
}
