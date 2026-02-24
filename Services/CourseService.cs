using AutoMapper;
using AutoMapper.QueryableExtensions;
using Examination_System.DTOs;
using Examination_System.DTOs.Course;
using Examination_System.DTOs.Instructor;
using Examination_System.Models;
using Examination_System.Repositories;

namespace Examination_System.Services
{
    public class CourseService
    {
        GeneralRepository<Course> _generalRepository;
        IMapper _mapper;
        public CourseService( IMapper mapper)
        {
            _generalRepository = new GeneralRepository<Course>();
            _mapper = mapper;
        }
        public IEnumerable<GetAllCoursesDTO> GetAll()
        {
            //Add Validation here if needed
            var query = _generalRepository.GetAll();

            var res = query.ProjectTo<GetAllCoursesDTO>(_mapper.ConfigurationProvider).ToList();
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
