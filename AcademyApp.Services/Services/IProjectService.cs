using AcademyApp.Domain.Domains;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyApp.Services.Services
{
    public interface IProjectService
    {
        List<Project> GetAllSProject();
        Project GetProjectById(int id);
        void AddNewProject(Project entity);
    }
}
