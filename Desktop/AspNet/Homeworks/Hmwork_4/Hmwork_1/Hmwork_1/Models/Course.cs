using System;
namespace Hmwork_1.Models
{
	public class Course
	{
        public int Id { get; set; }
        public double Price { get; set; }
        public string Desc { get; set; }
        public string TagName { get; set; }
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<CourseImages> Images { get; set; }

    }
}

