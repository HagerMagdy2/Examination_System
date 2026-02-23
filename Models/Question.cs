using System.ComponentModel.DataAnnotations;
using Examination_System.Models.Enums;

namespace Examination_System.Models
{
    public class Question : BaseModel
    {

        [Required]
        public string Text { get; set; } = null!;

        public QuestionLevel Level { get; set; }

        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; } = null!;

        public ICollection<Choice> Choices { get; set; } = new List<Choice>();
        public ICollection<ExamQuestion> ExamQuestions { get; set; } = new List<ExamQuestion>();
    }
}