using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_2.InterfacesService
{
    public interface IService<T>
    {

        Task<T> AddAsync(T model);
        void UpdateAsync(T model);
        Task DeleteAsync(int id);
        Task<T> GetByIdAsync(int id);
       Task< List<T>> GetAllAsync();
       // List<T> Search(int id = 0, string searchstring = "");


    }
}
