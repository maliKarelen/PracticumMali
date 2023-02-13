using AutoMapper;
using Repository;
using Microsoft.Extensions.DependencyInjection;
using Repository.ClassesRepository;
using Repository.Entities;
using Repository.InterfacesRepository;
using Service_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Service_2.InterfacesService;
using Service_2.ClassesService;

namespace Service_2
{
    //רק בסיעתא דשמיא!!!!!!!!!!!!!!!

    public static class Extention
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddRepositories();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IChildOfUserService, ChildOfUserService>();
            //MapperConfiguration config = new MapperConfiguration(
            //   conf => conf.CreateMap<User, UserModel>());
            //   //.ForMember(dest => dest.Id, opt => opt.MapFrom(dest => dest.Index))
            //   //.ReverseMap()
            //   //.ForMember(dest => dest.Index, opt => opt
            //   //.MapFrom(dest => dest.Id)));
            //IMapper mapper = config.CreateMapper();


            //services.AddSingleton(mapper);

            //services.AddDbContext<IDataSource, SqlDataSource>();

            //services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            return services;
        }
    }
}
