using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Examination_System.Models
{
    public class Course : BaseModel
    {

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;

        public int Hours { get; set; }
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; } = null!;
        public ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();
        public ICollection<Exam> Exams { get; set; } = new List<Exam>();
        //[InverseProperty("preRequesit")]
        //public ICollection<PreRequesit> PreRequesitCourse { get; set; }
        //[InverseProperty("MainCourse")]
        //public ICollection<PreRequesit> MainCourse { get; set; }
    }
}