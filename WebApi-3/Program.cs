using Service_2.ClassesService;
using Service_2.InterfacesService;
using Service_2.Models;
using AutoMapper;
using Service_2;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Repository;

namespace WebApi_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //IUserService _userService;
            //_userService =new UserService(_userService);
            //UserModel model=_userService.GetById(8);




            //var builder = WebApplication.CreateBuilder(args);



            ////services.AddScoped<IDataSourse, SqlDataSource>();
            //builder.Services.AddAutoMapper(typeof(Mapping));
            //builder.Services.AddServices();
            //// Add services to the container.

            //builder.Services.AddControllers();
            //// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            //builder.Services.AddEndpointsApiExplorer();
            //builder.Services.AddSwaggerGen();

            //var app = builder.Build();

            //// Configure the HTTP request pipeline.
            //if (app.Environment.IsDevelopment())
            //{
            //    app.UseSwagger();
            //    app.UseSwaggerUI();
            //}

            //app.UseHttpsRedirection();

            //app.UseAuthorization();


            //app.MapControllers();

            //app.Run();

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddCors(option => option.AddPolicy("corsPolicy", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddAutoMapper(typeof(Mapping));
            builder.Services.AddServices();
            //builder.Services.AddAutoMapper(typeof(Mapper));

            //Services.Extensions.AddRepoDependencies( builder.Services);
            //   builder.Services.AddRepoDependencies();
          
              var app = builder.Build();
            app.UseCors("corsPolicy");
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();


        }
    }
}