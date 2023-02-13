using Microsoft.Extensions.DependencyInjection;
using Repository.ClassesRepository;
using Repository.InterfacesRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public static class Extentions
    {
        //רק בסיעתא דשמיא
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IDataSource,SqlDataSource>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IChildOfUserRepository, ChildOfUserRepository>();

            return services;
        }
    }
}
