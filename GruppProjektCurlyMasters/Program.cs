using DbLibrary;
using GruppProjektCurlyMasters.Models;
using GruppProjektCurlyMasters.Services;
using Microsoft.EntityFrameworkCore;
using System;

namespace GruppProjektCurlyMasters
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<Context>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Connection")));
            builder.Services.AddScoped<IAppRepository<Project>, ProjectRepository>();
            builder.Services.AddScoped<IAppRepository<Employee>, EmployeeRepository>();
            builder.Services.AddScoped<IAppRepository<TimeReport>, TimeReportRepository>();


            var app = builder.Build();

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