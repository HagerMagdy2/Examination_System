using System.ComponentModel.DataAnnotations.Schema;

namespace Examination_System.Models
{
    public class PreRequesit : BaseModel
    {
        [ForeignKey("MainCourse")]
        public int MainCourseID { get; set; }

        [ForeignKey("preRequesit")]
        public int PreRequesitCourseID { get; set; }

        public Course MainCourse { get; set; }
        public Course preRequesit { get; set; }

        public bool IsMandatory { get; set; }
    }
}
