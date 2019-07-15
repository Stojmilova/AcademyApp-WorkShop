using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademyApp.WebApp.Models
{
    public class DetailsProjectViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int EstimatedTime { get; set; }
        public int TimeSpend { get; set; }
    }
}
