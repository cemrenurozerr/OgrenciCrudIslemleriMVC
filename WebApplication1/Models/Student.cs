namespace WebApplication1.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ClassRoomID { get; set; }
        public ClassRoom ClassRoom { get; set; }
    }
}
