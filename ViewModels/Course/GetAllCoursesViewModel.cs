

using Examination_System.ViewModels.Instructor;

namespace Examination_System.ViewModels.Course
{
    public class GetAllCoursesViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public GetInstructorInfoViewModel Instructor { get; set; }
    }
}
