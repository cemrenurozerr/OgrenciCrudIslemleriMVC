using WebApplication1.Models;

namespace WebApplication1.DefaultData
{
    public class Data
    {
        public static List<Student> Students = new List<Student>()
        {
            new Student(){ID=1, FirstName="cemre", LastName="özer",ClassRoomID=1},
            new Student(){ID=2, FirstName="cansu", LastName="kümber",ClassRoomID=1},
            new Student(){ID=3, FirstName="ceyda", LastName="özer",ClassRoomID=2},
            new Student(){ID=4, FirstName="ceren", LastName="özer",ClassRoomID=1}
        };
        public static List<ClassRoom> Classrooms = new List<ClassRoom>()
        {
            new ClassRoom(){ID=1,ClassName="C#",Students=Students.Where(x=>x.ClassRoomID==1).ToList()},
            new ClassRoom(){ID=2,ClassName="Java",Students=Students.Where(x=>x.ClassRoomID==2).ToList()}
        };

    }
}
