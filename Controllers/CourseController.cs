using AutoMapper;
using Examination_System.Data;
using Examination_System.DTOs;
using Examination_System.Models;
using Examination_System.Repositories;
using Examination_System.Services;
using Examination_System.ViewModels;
using Examination_System.ViewModels.Course;
using Examination_System.ViewModels.Instructor;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PredicateExtensions;
using System.Linq.Expressions;

namespace Examination_System.Controllers
{
    [Route("[controller]/[Action]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        //Context _context;
        GeneralRepository<Course> _courseRepository;
        CourseService _courseService;
        IMapper _mapper;
        public CourseController(IMapper mapper)
        {
            //_context = new Context();
            _courseRepository = new GeneralRepository<Course>();
            _courseService = new CourseService( mapper);
            _mapper = mapper;
        }
        //[HttpPost]
        //public bool AddCourse(Course course)
        //{
        //    _context.Courses.Add(course);
        //    _context.SaveChanges();
        //    return true;

        //}
        [HttpGet]
        public  IEnumerable<GetAllCoursesViewModel> GetAllCourses()
        {
            // return _context.Courses.Include(x=>x.Exams.Select(x=>x.Name)).Where(c=>!c.IsDeleted).ToList();
            var res=  _courseService.GetAll();
            //var list =new List<GetAllCoursesViewModel>();
            //foreach (var item in res) 
            //{
            //    list.Add(new GetAllCoursesViewModel()
            //    {
            //        ID = item.ID,
            //        Name = item.Name,
            //        Description = item.Description,
            //        Instructor = new GetInstructorInfoViewModel
            //        {
            //            ID = item.Instructor.ID,
            //            Name = item.Instructor.Name,
            //        }
            //    });

            //}
            var list = _mapper.Map<IEnumerable<GetAllCoursesViewModel>>(res);
            return list;

        }
        [HttpGet]
        public IEnumerable<Course> GetCourseWithFilters()
        {
            // return _context.Courses.Where(c => c.Name.Contains(name) && !c.IsDeleted).ToList();
            return _courseRepository.Get(x => x.Name.Contains("C#"));
        }
        [HttpGet]
        public IEnumerable<Course> Get(int? Id,string? Name, int?Houres)

        {
            //the old way before using predicate check for all filters and then apply them to the query 
            //var query = _courseRepository.GetAll();
            //if (Id.HasValue)
            //{
            //    query= query.Where(x => x.ID == Id.Value);
            //}
            //if (Houres.HasValue)
            //{
            //    query = query.Where(x => x.Houres > Houres.Value);
            //}
            //if (!string.IsNullOrEmpty(Name)) 
            //{
            //query=query.Where(x => x.Name.Contains(Name));
            //}
            // return _context.Courses.Where(c => c.Houres > houres && !c.IsDeleted).ToList();
            //var predicate = PredicateExtensions.PredicateExtensions.Begin<Course>(true);
            //if (Id.HasValue)
            //{
            //    predicate = predicate.And(x => x.ID == Id.Value);
            //}
            //if (Houres.HasValue)
            //{
            //    predicate = predicate.And(x => x.Houres > Houres.Value);
            //}
            //if (!string.IsNullOrEmpty(Name))
            //{
            //    predicate = predicate.And(x => x.Name.Contains(Name));
            //}
            var predicate = MyPredicateBuilder(Id, Name, Houres);
            var query=  _courseRepository.Get(predicate).ToList();
            return query;
        }
        private Expression<Func<Course, bool>> MyPredicateBuilder(int? Id, string? Name, int? Houres)
        {
            var predicate = PredicateExtensions.PredicateExtensions.Begin<Course>(true);
            if (Id.HasValue)
            {
                predicate = predicate.And(x => x.ID == Id.Value);
            }
            if (Houres.HasValue)
            {
                predicate = predicate.And(x => x.Hours >= Houres.Value);
            }
            if (!string.IsNullOrEmpty(Name))
            {
                predicate = predicate.And(x => x.Name.Contains(Name));
            }
            return predicate;
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
        public bool Update(UpdateCoursseRequestViewModel course)
        {
            var crs = new UpdateCourseRequestDTO()
            {
                Name=course.Name,
                Hours=course.Hours,
            };
            _courseService.UpdateCourse(crs);
                return true;

        }
    }
}


