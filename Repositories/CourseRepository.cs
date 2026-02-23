using Examination_System.Data;
using Examination_System.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.ExceptionServices;

namespace Examination_System.Repositories
{
    public class CourseRepository:GeneralRepository<Course>
    {
        Context _context;
        public CourseRepository()
        {
            _context = new Context();
        }
        public IQueryable<Course> GetAll()
        {
            //Add Validation here if needed
            return base.GetAll();
        }
        public async Task<Course> GetById(int id)
        {
            return await _context.Courses.Where(x => x.ID == id && !x.IsDeleted).FirstOrDefaultAsync();
        }
        public async Task<bool> AddCourse(Course course)
        {
            _context.Courses.Add(course);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteCourse(int id)
        {
            var course = _context.Courses.Where(x => x.ID == id).FirstOrDefault();
            course.IsDeleted = true;
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
