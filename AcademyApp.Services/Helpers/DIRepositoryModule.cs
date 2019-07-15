using AcademyApp.DataAccess;
using AcademyApp.DataAccess.EntityRepository;
using AcademyApp.Domain.Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyApp.Services.Helpers
{
    public static class DIRepositoryModule
    {
        public static IServiceCollection RegisterRepositories(IServiceCollection services)
        {
            services.AddDbContext<AcademyDbContext>(x =>
            x.UseSqlServer("Server=.\\SQLExpress;Database=AcademyDb;Trusted_Connection=True")
            );

            services.AddTransient<IRepository<Student>, StudentRepository>();
            services.AddTransient<IRepository<Project>, ProjectRepository>();

            return services;

        }
    }
}
