using System;
using AppliedActivity5.Database;

namespace AppliedActivity5.SeedDate
{
	public class DatabaseSeeder_cs
	{
        public static void SeedData()
        {
            using AppDbContext context = new AppDbContext();

            var students = new List<Student>
            {
                new Student { Name = "John Doe", Age = 20, Major = "Computer Science" },
                new Student { Name = "Jane Smith", Age = 22, Major = "Engineering" },
                // Add more students here
            };

            var courses = new List<Course>
            {
                new Course { CourseName = "Introduction to Programming", Instructor = "Prof. Johnson", RoomNumber = "101" },
                new Course { CourseName = "Data Structures", Instructor = "Prof. Williams", RoomNumber = "202" },
                // Add more courses here
            };

            context.Students.AddRange(students);
            context.Courses.AddRange(courses);
            context.SaveChanges();
        }
    }
}

