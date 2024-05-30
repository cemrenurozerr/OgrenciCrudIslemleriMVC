namespace WebApplication1.Models
{
	public class ClassRoom
	{
		public int ID { get; set; }
		public string ClassName { get; set; }
        public List<Student> Students{ get; set; }
        public ClassRoom()
        {
            Students = new List<Student>();
        }
    }
}
