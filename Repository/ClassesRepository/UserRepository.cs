using Microsoft.EntityFrameworkCore;
using Repository.Entities;
using Repository.InterfacesRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ClassesRepository
{
    //רק בסיעתא דשמיא!!!!!!!!!!!!!
    public class UserRepository : IUserRepository
    {
        IDataSource _dataSource;

        public UserRepository(IDataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public async Task< User> AddAsync(User entity)
        {

            _dataSource.users.Add(entity);
            await _dataSource.SaveChangesAsync();
            return entity;
        }

        public  async Task DeleteAsync(int id)
        {

          _dataSource.users.Remove(await GetByIdAsync(id));
          await _dataSource.SaveChangesAsync();
        }


        public async Task< List<User>> GetAllAsync()
        {
            return await _dataSource.users.ToListAsync();
               
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _dataSource.users.FindAsync(id);
        }

        public void UpdateAsync(User entity)
        {

           //_dataSource.Entry(entity) = EntityState.Modified;
        }
    }
}
