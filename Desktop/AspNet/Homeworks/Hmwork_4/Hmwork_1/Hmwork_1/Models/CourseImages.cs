using System;
namespace Hmwork_1.Models
{
	public class CourseImages
	{
        public int Id { get; set; }
        public string Image { get; set; }
        public bool IsMain { get; set; }
        public int? CourseId { get; set; }
        public Course Course { get; set; }
    }
}

