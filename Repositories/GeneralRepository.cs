using Examination_System.Data;
using Examination_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Examination_System.Repositories
{
    public class GeneralRepository<T> where T :BaseModel
    {
        Context _context;
        DbSet<T> _dbSet;
        public GeneralRepository()
        {
            _context = new Context();
            _dbSet = _context.Set<T>();
        }
        public IQueryable<T> GetAll()
        {
            return _dbSet.Where(x => !x.IsDelected);
        }
        public async Task<T> GetById(int id)
        {
            return await _dbSet.Where(x => x.ID == id && !x.IsDelected).FirstOrDefaultAsync();
        }
        //public async Task AddCourse(Course course)
        //{
        //    _context.Courses.Add(course);
        //    await _context.SaveChangesAsync();
        //}
        public async Task DeleteCourse(int id)
        {
            var course = await GetById(id);
            course.IsDelected = true;
            await _context.SaveChangesAsync();
            
        }
    }
}

