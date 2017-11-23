using AwesomeUniversity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwesomeUniversity.Data
{
    public class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students, if yes, we dont execute the rest
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            // the rest here to to initialize our DB with some Data
            var students = new Student[]
            {
            new Student{FirstName="Bruce",LastName="Wayne",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Tony",LastName="Stark",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstName="Bruce",LastName="Banner",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstName="Steve",LastName="Rogers",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstName="Stan",LastName="Lee",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstName="Peggy",LastName="Curter",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new Student{FirstName="Laura",LastName="Lane",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstName="Clark",LastName="Kent",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };
            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();

            var courses = new Course[]
            {
            new Course{CourseID=1050,Title="Flight",Credits=3},
            new Course{CourseID=4022,Title="Heat Vision",Credits=3},
            new Course{CourseID=4041,Title="Nano technology",Credits=3},
            new Course{CourseID=1045,Title="Smashing",Credits=4},
            new Course{CourseID=3141,Title="Being Awesome 101",Credits=4},
            new Course{CourseID=2021,Title="Composition",Credits=3},
            new Course{CourseID=2042,Title="Literature",Credits=4}
            };
            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
            new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
            new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
            new Enrollment{StudentID=3,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
            new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
            new Enrollment{StudentID=6,CourseID=1045},
            new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }
    }
}
