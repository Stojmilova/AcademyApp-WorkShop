using AcademyApp.Domain.Domains;
using AcademyApp.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyApp.DataAccess
{
    public class AcademyDbContext : DbContext
    {
        public AcademyDbContext(DbContextOptions options)
           : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Project> Projects { get; set; }

        protected override void OnModelCreating(
            ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>()
            .HasOne(x => x.Student)
            .WithMany(x => x.Projects)
            .HasForeignKey(x => x.StudentId);
            //modelBuilder.Entity<Student>()
            //  .HasMany(x => x.Projects)
            //  .WithOne(x => x.Student)
            //  .HasForeignKey(x => x.StudentId);

            //var project1 = new Project { Id = 1, Title = "JavaProject", EstimatedTime = 30, TimeSpend = 25, StudentId = 1, };
            //var project2 = new Project { Id = 2, Title = "HrApp", EstimatedTime = 80, TimeSpend = 75, StudentId = 1, };
            //var project3 = new Project { Id = 3, Title = "MVCProject", EstimatedTime = 30, TimeSpend = 25, StudentId = 2 };
            //var project4 = new Project { Id = 4, Title = "MyProject", EstimatedTime = 40, TimeSpend = 35, StudentId = 2, };
            //var project5 = new Project { Id = 5, Title = "JavaScriptProject", EstimatedTime = 50, TimeSpend = 45, StudentId = 3, };
            //var project6 = new Project { Id = 6, Title = "C#Project", EstimatedTime = 60, TimeSpend = 55, StudentId = 3, };

            modelBuilder.Entity<Project>()
                .HasData(
                new Project()
                {
                    Id = 1,
                    Title = "JavaProject",
                    EstimatedTime = 30,
                    TimeSpend = 25,
                    StudentId = 1,
                },
                 new Project()
                 {
                     Id = 2,
                     Title = "HrApp",
                     EstimatedTime = 80,
                     TimeSpend = 75,
                     StudentId = 1,
                 },
                 new Project()
                 {
                     Id = 3,
                     Title = "MVCProject",
                     EstimatedTime = 30,
                     TimeSpend = 25,
                     StudentId = 2
                 },
                  new Project()
                  {
                      Id = 4,
                      Title = "MyProject",
                      EstimatedTime = 40,
                      TimeSpend = 35,
                      StudentId = 2
                  },
                  new Project()
                  {
                      Id = 5,
                      Title = "JavaScriptProject",
                      EstimatedTime = 50,
                      TimeSpend = 45,
                      StudentId = 3
                  },
                   new Project()
                   {
                       Id = 6,
                       Title = "C#Project",
                       EstimatedTime = 60,
                       TimeSpend = 55,
                       StudentId = 3
                   });

            modelBuilder.Entity<Student>()
                 .HasData(
                 new Student()
                 {
                     Id = 1,
                     FirstName = "Bob",
                     LastName = "Bobsky",
                     Age = 25,
                     TypeOfAcademy = AcademyType.Design
                 },
                  new Student()
                  {
                      Id = 2,
                      FirstName = "Jill",
                      LastName = "Wayne",
                      Age = 26,
                      TypeOfAcademy = AcademyType.Design
                  },
                  new Student()
                  {
                      Id = 3,
                      FirstName = "John",
                      LastName = "Johnson",
                      Age = 27,
                      TypeOfAcademy = AcademyType.Network
                  });

        }
    }
}
