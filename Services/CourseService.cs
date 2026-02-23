using Examination_System.Models;
using Examination_System.Repositories;

namespace Examination_System.Services
{
    public class CourseService
    {
        GeneralRepository<Course> _generalRepository;
        public CourseService()
        {
            _generalRepository = new GeneralRepository<Course>();
        }
        public IQueryable<Course> GetAll()
        {
            //Add Validation here if needed
            return _generalRepository.GetAll();
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
    }
}
