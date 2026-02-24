using Examination_System.DTOs;
using Examination_System.DTOs.Course;
using Examination_System.DTOs.Instructor;
using Examination_System.Models;
using Examination_System.Repositories;

namespace Examination_System.Services
{
    public class UpdateCoursseRequestDTO
    {
        GeneralRepository<Course> _generalRepository;
        public UpdateCoursseRequestDTO()
        {
            _generalRepository = new GeneralRepository<Course>();
        }
        public IEnumerable<GetAllCoursesDTO> GetAll()
        {
            //Add Validation here if needed
            var res = _generalRepository.GetAll().Select(c => new GetAllCoursesDTO()
            {
                ID = c.ID,
                Name = c.Name,
                Description = c.Description,
                Instructor = new GetInstructorInfoDTO
                {
                    ID = c.Instructor.ID,
                    Name = c.Instructor.FullName,
                }
            }).ToList();

            
            return res;
        }
        public async Task<Course> GetById(int id)
        {
            return await _generalRepository.GetById(id);
        }
     
        public async Task<bool> DeleteCourse(int id)
        {
            _generalRepository.DeleteCourse(id);
            return true;
        }
        public void UpdateCourse(UpdateCourseRequestDTO course)
        {
            var crs = new Course()
            {
                Name=course.Name,
                Hours=course.Hours,
            };
            _generalRepository.Update(crs);
            
        }
        public async Task AddCourse(Course course)
        {
            _generalRepository.Add(course);
          
        }
    }
}
