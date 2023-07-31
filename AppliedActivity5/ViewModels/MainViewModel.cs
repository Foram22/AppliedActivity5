using System.Collections.ObjectModel;
using AppliedActivity5.Database;
using AppliedActivity5.SeedDate;

namespace AppliedActivity5.ViewModels
{
	public class MainViewModel
	{
        public ObservableCollection<Course> Courses { get; set; }
        public ObservableCollection<Student> Students { get; set; }

        public MainViewModel()
        {
            // Set up database and seed data
            using var context = new AppDbContext();
            context.Database.EnsureCreated();
            DatabaseSeeder.SeedData();

            // Get courses and students from the database
            Courses = new ObservableCollection<Course>(context.Courses);
            Students = new ObservableCollection<Student>(context.Students);
        }
    }
}

