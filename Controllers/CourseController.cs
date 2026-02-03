using Examination_System.Data;
using Examination_System.Models;
using Examination_System.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Examination_System.Controllers
{
    [Route("[controller]/[Action]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        //Context _context;
        GeneralRepository<Course> _courseRepository;
        public CourseController()
        {
            //_context = new Context();
            _courseRepository = new GeneralRepository<Course>();
        }
        //[HttpPost]
        //public bool AddCourse(Course course)
        //{
        //    _context.Courses.Add(course);
        //    _context.SaveChanges();
        //    return true;

        //}
        [HttpGet]
        public  IEnumerable<Course> GetAllCourses()
        {
            // return _context.Courses.Include(x=>x.Exams.Select(x=>x.Name)).Where(c=>!c.IsDeleted).ToList();
            return  _courseRepository.GetAll();

        }
        [HttpGet]
        public async Task<Course>  GetNameById(int id)
        {
            var course= await _courseRepository.GetById(id);
            
             //   var course = await _context.Courses.Where(c => c.ID == id&& !c.IsDeleted).FirstOrDefaultAsync();

                return course;
            
        }
        [HttpDelete]
        public async Task< bool> DeleteCourse(int id)
        {
            await _courseRepository.DeleteCourse(id);

            //var course = await _context.Courses.FindAsync(id);

            //course.IsDeleted = true;
            //   await _context.SaveChangesAsync();
                return true;
         
        }
        [HttpPut]
        public bool Update(Course course)
        {
            _courseRepository.UpdateInclude(course, nameof(Course.Name),nameof(Course.Houres));
            return true;

        }
    }
}


