using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplication1.Models
{
	public class StudentVM
	{
        public Student Student { get; set; }
        public List<SelectListItem> ClassRoomsForDropDown { get; set; }
    }
}
