using Microsoft.AspNetCore.Mvc;
using WebApplication1.DefaultData;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ClassRoomController : Controller
    {
        public IActionResult Index()
        {
            return View(Data.Classrooms);
        }
        public IActionResult GetStudents(int id)
        {
            List<Student> students=Data.Students.Where(x=>x.ClassRoomID.Equals(id)).ToList();
            return View(students);
        }
    }
}
