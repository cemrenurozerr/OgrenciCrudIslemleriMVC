using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication1.DefaultData;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students=Data.Students;
            return View(students);
        }
        public IActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            if (StudentExist(student.ID) != null)
            {
                TempData["result"] = "Daha önce böyle bir Id olduğundan kayıt ekleme başarısız.";
            }
            else
                Data.Students.Add(student);
            return RedirectToAction(nameof(Index));
        }
        public Student StudentExist(int id)
        {
            return Data.Students.FirstOrDefault(x=>x.ID.Equals(id));
        }
        public IActionResult UpdateStudent(int id)
        {
            StudentVM studentVM=new StudentVM();
            studentVM.Student=StudentExist(id);
            studentVM.ClassRoomsForDropDown = FillClassRooms();
            return View(studentVM);
        }
        [HttpPost]
        public IActionResult UpdateStudent(int id, StudentVM studentVM)
        {
            Student updateStudent=StudentExist(id);
            updateStudent.FirstName = studentVM.Student.FirstName;
            updateStudent.LastName = studentVM.Student.LastName;
            updateStudent.ClassRoomID = studentVM.Student.ClassRoomID;
            return RedirectToAction("Index");
        }
        public IActionResult DeleteStudent(int id)
        {
            Data.Students.Remove(StudentExist(id));
            return RedirectToAction(nameof(Index));
        }
		private List<SelectListItem> FillClassRooms()
		{
            return Data.Classrooms.Select(x => new SelectListItem()
            {
                Text=x.ClassName,
                Value=x.ID.ToString()
            }).ToList();
		}
	}
}
