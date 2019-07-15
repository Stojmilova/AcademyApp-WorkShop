using AcademyApp.Domain.Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyApp.DataAccess.EntityRepository
{
    public class ProjectRepository:IRepository<Project>
    {
        private AcademyDbContext _context;
        public ProjectRepository(AcademyDbContext context)
        {
            _context = context;
        }

        public void DeleteById(int id)
        {
            Project project = _context.Projects.FirstOrDefault(x => x.Id == id);
            if (project != null) _context.Projects.Remove(project);
            _context.SaveChanges();
        }

        public List<Project> GetAll()
        {
            return _context.Projects.ToList();
        }

        public Project GetById(int id)
        {
            return _context.Projects.FirstOrDefault(x => x.Id == id);
        }

        public void Insert(Project entity)
        {
            _context.Projects.Add(entity);
            _context.SaveChanges();

        }

        public void Update(Project entity)
        {
            Project project = _context.Projects.FirstOrDefault(x => x.Id == entity.Id);
            if (project != null)
            {
                entity.Id = project.Id;
                _context.Projects.Update(entity);
            }
        }
    }
}
