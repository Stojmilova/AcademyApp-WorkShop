using AcademyApp.Domain.Domains;
using AcademyApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademyApp.WebApp.Models
{
    public class StudentsViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public AcademyType TypeOfAcademy { get; set; }
        public List<Project> Projects { get; set; } = new List<Project>();
    }
}
