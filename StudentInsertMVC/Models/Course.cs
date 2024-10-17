using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentInsertMVC.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string name { get; set; }   //engg mca MBA    
    }
    public class CourseList
    {
      public List<Course> coursesList { get; set; }
        public string  SelectedCourse { get; set; }
        public int selectedCourseId { get; set; }
    }
}