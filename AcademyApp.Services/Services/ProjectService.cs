using System;
using System.Collections.Generic;
using System.Text;
using AcademyApp.DataAccess;
using AcademyApp.Domain.Domains;

namespace AcademyApp.Services.Services
{
    public class ProjectService : IProjectService
    {
        private IRepository<Project> _projectRepository;

        public ProjectService(IRepository<Project> projectRepository)
        {
            _projectRepository = projectRepository;

        }
        public void AddNewProject(Project entity)
        {
            _projectRepository.Insert(entity);
        }

        public List<Project> GetAllSProject()
        {
            return _projectRepository.GetAll();
        }

        public Project GetProjectById(int id)
        {
            return _projectRepository.GetById(id);
        }
    }
}
