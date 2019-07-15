using System;
using System.Collections.Generic;
using System.Text;
using AcademyApp.DataAccess;
using AcademyApp.Domain.Domains;

namespace AcademyApp.Services.Services
{
    public class StudentService : IStudentService
    {
        private IRepository<Student> _studentRepository;
      
        public StudentService(IRepository<Student> studentRepository)
        {
            _studentRepository = studentRepository;
        
        }

        public void AddNewStudent(Student entity)
        {
             _studentRepository.Insert(entity);
        }

        public List<Student> GetAllStudent()
        {
            return _studentRepository.GetAll();
        }

        public Student GetOrderById(int id)
        {
            return _studentRepository.GetById(id);
        }
    }
}
