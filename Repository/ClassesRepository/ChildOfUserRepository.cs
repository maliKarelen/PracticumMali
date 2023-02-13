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
    public class ChildOfUserRepository : IChildOfUserRepository
    {
        IDataSource dataSource;
        public ChildOfUserRepository(IDataSource ds)
        {

            dataSource = ds;
        }
        public async Task<ChildOfUser> AddAsync(ChildOfUser entity)
        {
            dataSource.Children.Add(entity);
           await dataSource.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(int id)
        {

                dataSource.Children.Remove(await GetByIdAsync(id));
            await dataSource.SaveChangesAsync();
        }

        public async Task<List<ChildOfUser>> GetAllAsync()
        {
            return await dataSource.Children.ToListAsync();
        }

        public async Task< ChildOfUser> GetByIdAsync(int id)
        {
            return await dataSource.Children.FindAsync(id);
        }

        public void UpdateAsync(ChildOfUser entity)
        {
            throw new NotImplementedException();
        }
    }
}
