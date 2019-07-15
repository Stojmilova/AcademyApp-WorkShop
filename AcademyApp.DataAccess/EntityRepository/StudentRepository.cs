using AcademyApp.Domain.Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyApp.DataAccess.EntityRepository
{
    public class StudentRepository:IRepository<Student>
    {
        private AcademyDbContext _context;
        public StudentRepository(AcademyDbContext context)
        {
            _context = context;
        }

        public void DeleteById(int id)
        {
            Student student = _context.Students.FirstOrDefault(x => x.Id == id);
            if (student != null) _context.Students.Remove(student);
            _context.SaveChanges();
        }

        public List<Student> GetAll()
        {
            return _context.Students.ToList();
        }

        public Student GetById(int id)
        {
            return _context.Students.FirstOrDefault(x => x.Id == id);
        }

        public void Insert(Student entity)
        {
            _context.Students.Add(entity);
            _context.SaveChanges();
        }

        public void Update(Student entity)
        {
            Student student = _context.Students.FirstOrDefault(x => x.Id == entity.Id);
            if (student != null)
            {
                entity.Id = student.Id;
                _context.Students.Update(entity);
            }
        }
    }
}
