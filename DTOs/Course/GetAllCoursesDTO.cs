using Examination_System.DTOs.Instructor;

namespace Examination_System.DTOs.Course
{
    public class GetAllCoursesDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public GetInstructorInfoDTO Instructor { get; set; }
    }
}
