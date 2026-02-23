using System.ComponentModel.DataAnnotations;

namespace Examination_System.Models
{
    public class Choice : BaseModel
    {

        [Required]
        public string Text { get; set; } = null!;

        public bool IsCorrect { get; set; }

        public int QuestionId { get; set; }
        public Question Question { get; set; } = null!;
    }
}