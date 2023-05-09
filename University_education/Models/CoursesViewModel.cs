using System;
using System.ComponentModel.DataAnnotations;

namespace University_education.Models
{
    public class CoursesViewModel
    {
        public string nameCourse { get; set; }

        public string typeCourse { get; set; }

        public string nivelCourse { get; set; }

        public double durationCourse { get; set; }

        public string turnCourse { get; set; }


    }
}
