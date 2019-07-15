using AcademyApp.Domain.Domains;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyApp.Services.Services
{
    public interface IStudentService
    {
        List<Student> GetAllStudent();
        Student GetOrderById(int id);
        void AddNewStudent(Student entity);
    }
}
