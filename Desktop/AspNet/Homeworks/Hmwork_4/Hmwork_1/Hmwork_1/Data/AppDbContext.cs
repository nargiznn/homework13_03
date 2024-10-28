using System;
using Hmwork_1.Models;
using Microsoft.EntityFrameworkCore;

namespace Hmwork_1.Data
{
	public class AppDbContext:DbContext
	{
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderLogo> SliderLogos { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CourseImages> CourseImages { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option) { }
    }
}

