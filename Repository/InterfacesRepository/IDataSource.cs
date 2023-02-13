using Microsoft.EntityFrameworkCore;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.InterfacesRepository
{
    public interface IDataSource
    {
        int SaveChanges();
      //  object Entry(User entity);

        //  object Entry(User entity);

        DbSet<ChildOfUser> Children { get; set; }
        DbSet<User> users { get; set; }
        //DbSet<HMO> yrrrr { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
