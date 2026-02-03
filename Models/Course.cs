namespace Examination_System.Models
{
    public class Course:BaseModel
    {
       
        public string Name { get; set; }
        public int Houres { get; set; }

        public ICollection<Exam> Exams { get; set; }
    }
}
