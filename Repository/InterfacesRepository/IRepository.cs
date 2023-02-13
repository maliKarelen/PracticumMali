using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.InterfacesRepository
{
    public interface IRepository<T>
    {

        Task<T> AddAsync(T entity);
        void UpdateAsync(T entity);

        Task DeleteAsync(int id);

        Task<T> GetByIdAsync( int id);

        Task<List<T>> GetAllAsync();

       // List<T> Search(int id);

    }
}
