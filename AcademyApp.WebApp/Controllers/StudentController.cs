using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcademyApp.Domain.Domains;
using AcademyApp.Services.Services;
using AcademyApp.WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AcademyApp.WebApp.Controllers
{
    public class StudentController : Controller
    {
        private IStudentService _studentService;
        private IProjectService _projectService;

        public StudentController(IStudentService studentService, IProjectService projectService)
        {
            _studentService = studentService;
            _projectService = projectService;
        }
        public IActionResult Students()
        {
            List<Student> students = _studentService.GetAllStudent();
            List<StudentsViewModel> viewModel = new List<StudentsViewModel>();
            foreach (var student in students)
            {
                viewModel.Add(new StudentsViewModel()
                {
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    Age = student.Age,
                    TypeOfAcademy = student.TypeOfAcademy,
                    Projects = _projectService.GetAllSProject().Where(x => x.StudentId == student.Id).ToList()
                });

            }
            return View(viewModel);
        }

        [HttpGet("AddStudent")]
        public IActionResult AddStudent()
        {
            AddStudentViewModel model = new AddStudentViewModel();
            return View(model);
        }

        [HttpPost("AddStudent")]
        public IActionResult AddStudent(AddStudentViewModel model)
        {
            Student student = new Student()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Age = model.Age,
                TypeOfAcademy = model.TypeOfAcademy
            };
            _studentService.AddNewStudent(student);
            return View("_ThankYouView");
        }
        public IActionResult Details()
        {
            List<Student> students = _studentService.GetAllStudent();
            List<AddStudentViewModel> viewModel = new List<AddStudentViewModel>();

            foreach (var student in students)
            {
                viewModel.Add(new AddStudentViewModel()
                {
                    Id = student.Id,
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    Age = student.Age,
                    TypeOfAcademy = student.TypeOfAcademy
                });
            }
            return View(viewModel);
        }
        [Route("Student/DetailsProject/{id}")]
        public IActionResult DetailsProject(int id)
        {
            var projects = _projectService.GetAllSProject().Where(x => x.StudentId == id).ToList();

            List<DetailsProjectViewModel> viewModel = new List<DetailsProjectViewModel>();
            foreach (var project in projects)
            {
                viewModel.Add(new DetailsProjectViewModel()
                {
                    Id = project.Id,
                    Title = project.Title,
                    EstimatedTime = project.EstimatedTime,
                    TimeSpend = project.TimeSpend,
                });
            }
            return View(viewModel);
        }

        [HttpGet("AddProject")]
        public IActionResult AddProject()
        {
            AddProjectViewModel model = new AddProjectViewModel();
            return View(model);
        }

        [HttpPost("AddProject")]
        public IActionResult AddProject(AddProjectViewModel model)
        {
            Student student = _studentService.GetOrderById(model.StudentId);
            Project project = new Project()
            {
                Id = model.Id,
                Title = model.Title,
                EstimatedTime = model.EstimatedTime,
                TimeSpend = model.TimeSpend,
                Student = student
            };
            _projectService.AddNewProject(project);
            return View();
        }

    }
}