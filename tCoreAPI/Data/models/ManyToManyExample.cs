using System.Collections.Generic;

namespace tCoreAPI.Data.models
{
    // 1)
    public class Student
    {
        public int StudentId { get; set; }
        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }

    // 2)
    public class Course
    {
        public int CourseId { get; set; }
        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }

    // 3)
    public class StudentCourse
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }

    // 4)
    //got to => TDataContext fluent API
}
