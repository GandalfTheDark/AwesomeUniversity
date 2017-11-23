using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwesomeUniversity.Models
{
    public enum Grade {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public Grade? Grade { get; set; } // The ? means we can have a null value for Grade

        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}
