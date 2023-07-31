using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AppliedActivity5.Database
{
	public class AppDbContext : DbContext
	{
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=app.db");
        }

        public AppDbContext()
		{
		}
	}
}

