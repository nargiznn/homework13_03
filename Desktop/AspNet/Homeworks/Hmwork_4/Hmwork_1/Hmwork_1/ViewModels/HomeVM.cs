using System;
using Hmwork_1.Models;

namespace Hmwork_1.ViewModels
{
	public class HomeVM
	{
        public List<Slider> Sliders { get; set; }
        public SliderLogo SliderLogos { get; set; }
        public List<Course> Courses { get; set; }
        public List<CourseImages> CourseImages { get; set; }
        public List<Category> Categories { get; set; }

    }
}

