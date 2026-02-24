using Examination_System.DTOs;
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
        public IEnumerable<Course> GetAll()
        {
            //Add Validation here if needed
            return _generalRepository.GetAll().ToList();
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
