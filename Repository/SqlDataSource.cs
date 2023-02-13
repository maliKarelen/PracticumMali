using Microsoft.EntityFrameworkCore;
using Repository.Entities;
using Repository.InterfacesRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Repository
{
    public class SqlDataSource : DbContext, IDataSource
    {

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Data Source=sqlsrv;Initial Catalog=Mali_Prac;Integrated Security=True;TrustServerCertificate=true");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ChildOfUser>().ToTable("ChildOfUser");
            modelBuilder.Entity<User>().ToTable("User");

        }

        //public override int SaveChanges()
        //{
        //    return base.SaveChanges();
        //}
        public DbSet<ChildOfUser> Children { get ; set; }
        public DbSet<User> users { get; set; }


    }
}
