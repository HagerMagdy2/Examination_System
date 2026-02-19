using Examination_System.Data;
using Examination_System.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;

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
        public IQueryable<T> Get(Expression<Func<T,bool>> expression)
        {
            var res =GetAll().Where(expression);
            return res;
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
        public void UpdateInclude( T entity,params string[] modifiedProperties)
        {
            if (_dbSet.Any(x=>x.ID==entity.ID))
            {
                return;
            }
            var local=_dbSet.Local.FirstOrDefault(x=>x.ID==entity.ID);
            EntityEntry entityEntry;
            if (local == null)
            {
                entityEntry = _context.Entry(entity);
            }
            else
            {
                entityEntry=_context.ChangeTracker.Entries<T>().FirstOrDefault(x=>x.Entity.ID==entity.ID);

            }
            foreach (var property in entityEntry.Properties)
            {
                if (modifiedProperties.Contains(property.Metadata.Name))
                {
                    property.CurrentValue = entity.GetType().GetProperty(property.Metadata.Name).GetValue(entity);
                    property.IsModified = true;
                }

            }
            _context.SaveChanges();
        }
    }
}

